#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class StrengthSurfaceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.StrengthSurface>
    {
        /// <inheritdoc />
        public override global::Terra.StrengthSurface Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant8), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score7++;
                    }
                }
            }
            var __score8 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant9), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score8++;
                    }
                }
            }
            var __score9 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant10), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score9++;
                    }
                }
            }
            var __score10 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant11), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score10++;
                    }
                }
            }
            var __score11 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(string), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score11++;
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
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }

            global::Terra.StrengthSurfaceVariant1? strengthSurfaceVariant1 = default;
            global::Terra.StrengthSurfaceVariant2? strengthSurfaceVariant2 = default;
            global::Terra.StrengthSurfaceVariant3? strengthSurfaceVariant3 = default;
            global::Terra.StrengthSurfaceVariant4? strengthSurfaceVariant4 = default;
            global::Terra.StrengthSurfaceVariant5? strengthSurfaceVariant5 = default;
            global::Terra.StrengthSurfaceVariant6? strengthSurfaceVariant6 = default;
            global::Terra.StrengthSurfaceVariant7? strengthSurfaceVariant7 = default;
            global::Terra.StrengthSurfaceVariant8? strengthSurfaceVariant8 = default;
            global::Terra.StrengthSurfaceVariant9? strengthSurfaceVariant9 = default;
            global::Terra.StrengthSurfaceVariant10? strengthSurfaceVariant10 = default;
            global::Terra.StrengthSurfaceVariant11? strengthSurfaceVariant11 = default;
            string? strengthSurfaceVariant12 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant1).Name}");
                        strengthSurfaceVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant2).Name}");
                        strengthSurfaceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant3).Name}");
                        strengthSurfaceVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant4).Name}");
                        strengthSurfaceVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant5).Name}");
                        strengthSurfaceVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant6).Name}");
                        strengthSurfaceVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant7).Name}");
                        strengthSurfaceVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant8).Name}");
                        strengthSurfaceVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 8)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant9).Name}");
                        strengthSurfaceVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 9)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant10).Name}");
                        strengthSurfaceVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 10)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant11).Name}");
                        strengthSurfaceVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 11)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        strengthSurfaceVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant1).Name}");
                    strengthSurfaceVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant2).Name}");
                    strengthSurfaceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant3).Name}");
                    strengthSurfaceVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant4).Name}");
                    strengthSurfaceVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant5).Name}");
                    strengthSurfaceVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant6).Name}");
                    strengthSurfaceVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant7).Name}");
                    strengthSurfaceVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant8).Name}");
                    strengthSurfaceVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant9).Name}");
                    strengthSurfaceVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant10).Name}");
                    strengthSurfaceVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant11).Name}");
                    strengthSurfaceVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthSurfaceVariant1 == null && strengthSurfaceVariant2 == null && strengthSurfaceVariant3 == null && strengthSurfaceVariant4 == null && strengthSurfaceVariant5 == null && strengthSurfaceVariant6 == null && strengthSurfaceVariant7 == null && strengthSurfaceVariant8 == null && strengthSurfaceVariant9 == null && strengthSurfaceVariant10 == null && strengthSurfaceVariant11 == null && strengthSurfaceVariant12 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    strengthSurfaceVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.StrengthSurface(
                strengthSurfaceVariant1,

                strengthSurfaceVariant2,

                strengthSurfaceVariant3,

                strengthSurfaceVariant4,

                strengthSurfaceVariant5,

                strengthSurfaceVariant6,

                strengthSurfaceVariant7,

                strengthSurfaceVariant8,

                strengthSurfaceVariant9,

                strengthSurfaceVariant10,

                strengthSurfaceVariant11,

                strengthSurfaceVariant12
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.StrengthSurface value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStrengthSurfaceVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant1!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant2!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant3!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant4!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant5!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant6!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant7!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant8!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant9!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant10!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthSurfaceVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthSurfaceVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthSurfaceVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant11!.Value, typeInfo);
            }
            else if (value.IsStrengthSurfaceVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthSurfaceVariant12!, typeInfo);
            }
        }
    }
}