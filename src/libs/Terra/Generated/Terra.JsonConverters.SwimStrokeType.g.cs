#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class SwimStrokeTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.SwimStrokeType>
    {
        /// <inheritdoc />
        public override global::Terra.SwimStrokeType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant1), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant2), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant3), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant4), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant5), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __score5 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant6), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score5++;
                    }
                }
            }
            var __score6 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant7), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score6++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Terra.SwimStrokeTypeVariant1? swimStrokeTypeVariant1 = default;
            global::Terra.SwimStrokeTypeVariant2? swimStrokeTypeVariant2 = default;
            global::Terra.SwimStrokeTypeVariant3? swimStrokeTypeVariant3 = default;
            global::Terra.SwimStrokeTypeVariant4? swimStrokeTypeVariant4 = default;
            global::Terra.SwimStrokeTypeVariant5? swimStrokeTypeVariant5 = default;
            global::Terra.SwimStrokeTypeVariant6? swimStrokeTypeVariant6 = default;
            global::Terra.SwimStrokeTypeVariant7? swimStrokeTypeVariant7 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant1).Name}");
                        swimStrokeTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant2).Name}");
                        swimStrokeTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant3).Name}");
                        swimStrokeTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant4).Name}");
                        swimStrokeTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant5).Name}");
                        swimStrokeTypeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 5)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant6).Name}");
                        swimStrokeTypeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 6)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant7).Name}");
                        swimStrokeTypeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (swimStrokeTypeVariant1 == null && swimStrokeTypeVariant2 == null && swimStrokeTypeVariant3 == null && swimStrokeTypeVariant4 == null && swimStrokeTypeVariant5 == null && swimStrokeTypeVariant6 == null && swimStrokeTypeVariant7 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant1).Name}");
                    swimStrokeTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (swimStrokeTypeVariant1 == null && swimStrokeTypeVariant2 == null && swimStrokeTypeVariant3 == null && swimStrokeTypeVariant4 == null && swimStrokeTypeVariant5 == null && swimStrokeTypeVariant6 == null && swimStrokeTypeVariant7 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant2).Name}");
                    swimStrokeTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (swimStrokeTypeVariant1 == null && swimStrokeTypeVariant2 == null && swimStrokeTypeVariant3 == null && swimStrokeTypeVariant4 == null && swimStrokeTypeVariant5 == null && swimStrokeTypeVariant6 == null && swimStrokeTypeVariant7 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant3).Name}");
                    swimStrokeTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (swimStrokeTypeVariant1 == null && swimStrokeTypeVariant2 == null && swimStrokeTypeVariant3 == null && swimStrokeTypeVariant4 == null && swimStrokeTypeVariant5 == null && swimStrokeTypeVariant6 == null && swimStrokeTypeVariant7 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant4).Name}");
                    swimStrokeTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (swimStrokeTypeVariant1 == null && swimStrokeTypeVariant2 == null && swimStrokeTypeVariant3 == null && swimStrokeTypeVariant4 == null && swimStrokeTypeVariant5 == null && swimStrokeTypeVariant6 == null && swimStrokeTypeVariant7 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant5).Name}");
                    swimStrokeTypeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (swimStrokeTypeVariant1 == null && swimStrokeTypeVariant2 == null && swimStrokeTypeVariant3 == null && swimStrokeTypeVariant4 == null && swimStrokeTypeVariant5 == null && swimStrokeTypeVariant6 == null && swimStrokeTypeVariant7 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant6).Name}");
                    swimStrokeTypeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (swimStrokeTypeVariant1 == null && swimStrokeTypeVariant2 == null && swimStrokeTypeVariant3 == null && swimStrokeTypeVariant4 == null && swimStrokeTypeVariant5 == null && swimStrokeTypeVariant6 == null && swimStrokeTypeVariant7 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant7).Name}");
                    swimStrokeTypeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.SwimStrokeType(
                swimStrokeTypeVariant1,

                swimStrokeTypeVariant2,

                swimStrokeTypeVariant3,

                swimStrokeTypeVariant4,

                swimStrokeTypeVariant5,

                swimStrokeTypeVariant6,

                swimStrokeTypeVariant7
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.SwimStrokeType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSwimStrokeTypeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimStrokeTypeVariant1!.Value, typeInfo);
            }
            else if (value.IsSwimStrokeTypeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimStrokeTypeVariant2!.Value, typeInfo);
            }
            else if (value.IsSwimStrokeTypeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimStrokeTypeVariant3!.Value, typeInfo);
            }
            else if (value.IsSwimStrokeTypeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimStrokeTypeVariant4!.Value, typeInfo);
            }
            else if (value.IsSwimStrokeTypeVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimStrokeTypeVariant5!.Value, typeInfo);
            }
            else if (value.IsSwimStrokeTypeVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimStrokeTypeVariant6!.Value, typeInfo);
            }
            else if (value.IsSwimStrokeTypeVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimStrokeTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimStrokeTypeVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimStrokeTypeVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimStrokeTypeVariant7!.Value, typeInfo);
            }
        }
    }
}