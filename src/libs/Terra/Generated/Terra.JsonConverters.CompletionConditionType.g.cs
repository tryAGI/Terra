#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class CompletionConditionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.CompletionConditionType>
    {
        /// <inheritdoc />
        public override global::Terra.CompletionConditionType Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant8), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant9), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant10), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant11), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant12), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score11++;
                    }
                }
            }
            var __score12 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant13), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score12++;
                    }
                }
            }
            var __score13 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant14), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score13++;
                    }
                }
            }
            var __score14 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant15), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score14++;
                    }
                }
            }
            var __score15 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant16), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score15++;
                    }
                }
            }
            var __score16 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant17), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score16++;
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
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }

            global::Terra.CompletionConditionTypeVariant1? completionConditionTypeVariant1 = default;
            global::Terra.CompletionConditionTypeVariant2? completionConditionTypeVariant2 = default;
            global::Terra.CompletionConditionTypeVariant3? completionConditionTypeVariant3 = default;
            global::Terra.CompletionConditionTypeVariant4? completionConditionTypeVariant4 = default;
            global::Terra.CompletionConditionTypeVariant5? completionConditionTypeVariant5 = default;
            global::Terra.CompletionConditionTypeVariant6? completionConditionTypeVariant6 = default;
            global::Terra.CompletionConditionTypeVariant7? completionConditionTypeVariant7 = default;
            global::Terra.CompletionConditionTypeVariant8? completionConditionTypeVariant8 = default;
            global::Terra.CompletionConditionTypeVariant9? completionConditionTypeVariant9 = default;
            global::Terra.CompletionConditionTypeVariant10? completionConditionTypeVariant10 = default;
            global::Terra.CompletionConditionTypeVariant11? completionConditionTypeVariant11 = default;
            global::Terra.CompletionConditionTypeVariant12? completionConditionTypeVariant12 = default;
            global::Terra.CompletionConditionTypeVariant13? completionConditionTypeVariant13 = default;
            global::Terra.CompletionConditionTypeVariant14? completionConditionTypeVariant14 = default;
            global::Terra.CompletionConditionTypeVariant15? completionConditionTypeVariant15 = default;
            global::Terra.CompletionConditionTypeVariant16? completionConditionTypeVariant16 = default;
            global::Terra.CompletionConditionTypeVariant17? completionConditionTypeVariant17 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant1).Name}");
                        completionConditionTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant2).Name}");
                        completionConditionTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant3).Name}");
                        completionConditionTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant4).Name}");
                        completionConditionTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant5).Name}");
                        completionConditionTypeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant6).Name}");
                        completionConditionTypeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant7).Name}");
                        completionConditionTypeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant8).Name}");
                        completionConditionTypeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant9).Name}");
                        completionConditionTypeVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant10).Name}");
                        completionConditionTypeVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant11).Name}");
                        completionConditionTypeVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant12).Name}");
                        completionConditionTypeVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 12)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant13).Name}");
                        completionConditionTypeVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 13)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant14).Name}");
                        completionConditionTypeVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 14)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant15).Name}");
                        completionConditionTypeVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 15)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant16).Name}");
                        completionConditionTypeVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 16)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant17).Name}");
                        completionConditionTypeVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant1).Name}");
                    completionConditionTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant2).Name}");
                    completionConditionTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant3).Name}");
                    completionConditionTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant4).Name}");
                    completionConditionTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant5).Name}");
                    completionConditionTypeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant6).Name}");
                    completionConditionTypeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant7).Name}");
                    completionConditionTypeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant8).Name}");
                    completionConditionTypeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant9).Name}");
                    completionConditionTypeVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant10).Name}");
                    completionConditionTypeVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant11).Name}");
                    completionConditionTypeVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant12).Name}");
                    completionConditionTypeVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant13).Name}");
                    completionConditionTypeVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant14).Name}");
                    completionConditionTypeVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant15).Name}");
                    completionConditionTypeVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant16).Name}");
                    completionConditionTypeVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (completionConditionTypeVariant1 == null && completionConditionTypeVariant2 == null && completionConditionTypeVariant3 == null && completionConditionTypeVariant4 == null && completionConditionTypeVariant5 == null && completionConditionTypeVariant6 == null && completionConditionTypeVariant7 == null && completionConditionTypeVariant8 == null && completionConditionTypeVariant9 == null && completionConditionTypeVariant10 == null && completionConditionTypeVariant11 == null && completionConditionTypeVariant12 == null && completionConditionTypeVariant13 == null && completionConditionTypeVariant14 == null && completionConditionTypeVariant15 == null && completionConditionTypeVariant16 == null && completionConditionTypeVariant17 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant17).Name}");
                    completionConditionTypeVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.CompletionConditionType(
                completionConditionTypeVariant1,

                completionConditionTypeVariant2,

                completionConditionTypeVariant3,

                completionConditionTypeVariant4,

                completionConditionTypeVariant5,

                completionConditionTypeVariant6,

                completionConditionTypeVariant7,

                completionConditionTypeVariant8,

                completionConditionTypeVariant9,

                completionConditionTypeVariant10,

                completionConditionTypeVariant11,

                completionConditionTypeVariant12,

                completionConditionTypeVariant13,

                completionConditionTypeVariant14,

                completionConditionTypeVariant15,

                completionConditionTypeVariant16,

                completionConditionTypeVariant17
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.CompletionConditionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompletionConditionTypeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant1!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant2!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant3!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant4!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant5!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant6!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant7!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant8!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant9!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant10!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant11!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant12!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant13!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant14!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant15!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant16!.Value, typeInfo);
            }
            else if (value.IsCompletionConditionTypeVariant17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CompletionConditionTypeVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CompletionConditionTypeVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CompletionConditionTypeVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionConditionTypeVariant17!.Value, typeInfo);
            }
        }
    }
}