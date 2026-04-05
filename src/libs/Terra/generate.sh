dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/tryterra/openapi/refs/heads/master/v5-bundled.yaml

# Convert OpenAPI 3.1.0 to 3.0.3 (AutoSDK requires 3.0.x)
python3 - openapi.yaml << 'PYEOF'
import yaml, sys

def convert_schema(schema):
    if not isinstance(schema, dict):
        return schema
    schema.pop('$schema', None)
    schema.pop('$id', None)
    if 'examples' in schema and isinstance(schema['examples'], list):
        if schema['examples']:
            schema['example'] = schema['examples'][0]
        del schema['examples']
    if 'const' in schema:
        schema['enum'] = [schema.pop('const')]
    if 'oneOf' in schema:
        items = schema['oneOf']
        if isinstance(items, list) and all(isinstance(i, dict) and 'const' in i for i in items):
            enum_values = [i['const'] for i in items]
            item_type = items[0].get('type', 'string')
            new_schema = {'type': item_type, 'enum': enum_values}
            if 'description' in schema:
                new_schema['description'] = schema['description']
            return new_schema
        schema['oneOf'] = [convert_schema(i) for i in items]
    if 'type' in schema and isinstance(schema['type'], list):
        types = [t for t in schema['type'] if t != 'null']
        if len(types) == 1:
            schema['type'] = types[0]
            schema['nullable'] = True
        elif types:
            schema['type'] = types[0]
    for key in ['properties', 'additionalProperties', 'items']:
        if key in schema:
            if isinstance(schema[key], dict):
                if key == 'properties':
                    for k, v in schema[key].items():
                        schema[key][k] = convert_schema(v)
                else:
                    schema[key] = convert_schema(schema[key])
    for key in ['allOf', 'anyOf', 'oneOf']:
        if key in schema and isinstance(schema[key], list):
            schema[key] = [convert_schema(i) for i in schema[key]]
    return schema

path = sys.argv[1]
with open(path) as f:
    spec = yaml.safe_load(f)

spec['openapi'] = '3.0.3'

for p in (spec.get('paths') or {}).values():
    for method in ['get','post','put','patch','delete','options','head','trace']:
        op = p.get(method)
        if not isinstance(op, dict):
            continue
        for param in (op.get('parameters') or []):
            if 'schema' in param:
                param['schema'] = convert_schema(param['schema'])
            if 'examples' in param:
                if isinstance(param['examples'], list) and param['examples']:
                    param['example'] = param['examples'][0]
                del param['examples']
        rb = op.get('requestBody')
        if isinstance(rb, dict):
            for mt in (rb.get('content') or {}).values():
                if isinstance(mt, dict) and 'schema' in mt:
                    mt['schema'] = convert_schema(mt['schema'])
        for code, resp in (op.get('responses') or {}).items():
            if isinstance(resp, dict):
                for mt in (resp.get('content') or {}).values():
                    if isinstance(mt, dict) and 'schema' in mt:
                        mt['schema'] = convert_schema(mt['schema'])

for name, schema in (spec.get('components', {}).get('schemas') or {}).items():
    spec['components']['schemas'][name] = convert_schema(schema)

with open(path, 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, sort_keys=False, allow_unicode=True, width=200)
PYEOF

# Remove per-operation dev-id parameters (will be added via PrepareRequest hook)
python3 -c "
import yaml
with open('openapi.yaml') as f:
    spec = yaml.safe_load(f)

for path_item in (spec.get('paths') or {}).values():
    for method in ['get','post','put','patch','delete','options','head','trace']:
        op = path_item.get(method)
        if not isinstance(op, dict):
            continue
        if 'parameters' in op:
            op['parameters'] = [p for p in op['parameters'] if not (isinstance(p, dict) and p.get('name') == 'dev-id')]

with open('openapi.yaml', 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, sort_keys=False, allow_unicode=True, width=200)
"

autosdk generate openapi.yaml \
  --namespace Terra \
  --clientClassName TerraClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
