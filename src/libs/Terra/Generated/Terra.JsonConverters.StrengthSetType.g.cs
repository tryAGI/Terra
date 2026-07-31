#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class StrengthSetTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.StrengthSetType>
    {
        /// <inheritdoc />
        public override global::Terra.StrengthSetType Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant7), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score6++;
                    }
                }
            }
            var __score7 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(string), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score7++;
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
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::Terra.StrengthSetTypeVariant1? strengthSetTypeVariant1 = default;
            global::Terra.StrengthSetTypeVariant2? strengthSetTypeVariant2 = default;
            global::Terra.StrengthSetTypeVariant3? strengthSetTypeVariant3 = default;
            global::Terra.StrengthSetTypeVariant4? strengthSetTypeVariant4 = default;
            global::Terra.StrengthSetTypeVariant5? strengthSetTypeVariant5 = default;
            global::Terra.StrengthSetTypeVariant6? strengthSetTypeVariant6 = default;
            global::Terra.StrengthSetTypeVariant7? strengthSetTypeVariant7 = default;
            string? strengthSetTypeVariant8 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant1).Name}");
                        strengthSetTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant2).Name}");
                        strengthSetTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant3).Name}");
                        strengthSetTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant4).Name}");
                        strengthSetTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant5).Name}");
                        strengthSetTypeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant6).Name}");
                        strengthSetTypeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant7).Name}");
                        strengthSetTypeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 7)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        strengthSetTypeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (strengthSetTypeVariant1 == null && strengthSetTypeVariant2 == null && strengthSetTypeVariant3 == null && strengthSetTypeVariant4 == null && strengthSetTypeVariant5 == null && strengthSetTypeVariant6 == null && strengthSetTypeVariant7 == null && strengthSetTypeVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant1).Name}");
                    strengthSetTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSetTypeVariant1 == null && strengthSetTypeVariant2 == null && strengthSetTypeVariant3 == null && strengthSetTypeVariant4 == null && strengthSetTypeVariant5 == null && strengthSetTypeVariant6 == null && strengthSetTypeVariant7 == null && strengthSetTypeVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant2).Name}");
                    strengthSetTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSetTypeVariant1 == null && strengthSetTypeVariant2 == null && strengthSetTypeVariant3 == null && strengthSetTypeVariant4 == null && strengthSetTypeVariant5 == null && strengthSetTypeVariant6 == null && strengthSetTypeVariant7 == null && strengthSetTypeVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant3).Name}");
                    strengthSetTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSetTypeVariant1 == null && strengthSetTypeVariant2 == null && strengthSetTypeVariant3 == null && strengthSetTypeVariant4 == null && strengthSetTypeVariant5 == null && strengthSetTypeVariant6 == null && strengthSetTypeVariant7 == null && strengthSetTypeVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant4).Name}");
                    strengthSetTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSetTypeVariant1 == null && strengthSetTypeVariant2 == null && strengthSetTypeVariant3 == null && strengthSetTypeVariant4 == null && strengthSetTypeVariant5 == null && strengthSetTypeVariant6 == null && strengthSetTypeVariant7 == null && strengthSetTypeVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant5).Name}");
                    strengthSetTypeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSetTypeVariant1 == null && strengthSetTypeVariant2 == null && strengthSetTypeVariant3 == null && strengthSetTypeVariant4 == null && strengthSetTypeVariant5 == null && strengthSetTypeVariant6 == null && strengthSetTypeVariant7 == null && strengthSetTypeVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant6).Name}");
                    strengthSetTypeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSetTypeVariant1 == null && strengthSetTypeVariant2 == null && strengthSetTypeVariant3 == null && strengthSetTypeVariant4 == null && strengthSetTypeVariant5 == null && strengthSetTypeVariant6 == null && strengthSetTypeVariant7 == null && strengthSetTypeVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant7).Name}");
                    strengthSetTypeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSetTypeVariant1 == null && strengthSetTypeVariant2 == null && strengthSetTypeVariant3 == null && strengthSetTypeVariant4 == null && strengthSetTypeVariant5 == null && strengthSetTypeVariant6 == null && strengthSetTypeVariant7 == null && strengthSetTypeVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    strengthSetTypeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.StrengthSetType(
                strengthSetTypeVariant1,

                strengthSetTypeVariant2,

                strengthSetTypeVariant3,

                strengthSetTypeVariant4,

                strengthSetTypeVariant5,

                strengthSetTypeVariant6,

                strengthSetTypeVariant7,

                strengthSetTypeVariant8
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.StrengthSetType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStrengthSetTypeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSetTypeVariant1!.Value, typeInfo);
            }
            else if (value.IsStrengthSetTypeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSetTypeVariant2!.Value, typeInfo);
            }
            else if (value.IsStrengthSetTypeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSetTypeVariant3!.Value, typeInfo);
            }
            else if (value.IsStrengthSetTypeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSetTypeVariant4!.Value, typeInfo);
            }
            else if (value.IsStrengthSetTypeVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSetTypeVariant5!.Value, typeInfo);
            }
            else if (value.IsStrengthSetTypeVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSetTypeVariant6!.Value, typeInfo);
            }
            else if (value.IsStrengthSetTypeVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSetTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSetTypeVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSetTypeVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSetTypeVariant7!.Value, typeInfo);
            }
            else if (value.IsStrengthSetTypeVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSetTypeVariant8!, typeInfo);
            }
        }
    }
}