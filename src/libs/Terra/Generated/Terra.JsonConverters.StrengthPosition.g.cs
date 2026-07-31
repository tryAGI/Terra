#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class StrengthPositionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.StrengthPosition>
    {
        /// <inheritdoc />
        public override global::Terra.StrengthPosition Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant8), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant9), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant10), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant11), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant12), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant13), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant14), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant15), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant16), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant17), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score16++;
                    }
                }
            }
            var __score17 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant18), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score17++;
                    }
                }
            }
            var __score18 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant19), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score18++;
                    }
                }
            }
            var __score19 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(string), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score19++;
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
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }

            global::Terra.StrengthPositionVariant1? strengthPositionVariant1 = default;
            global::Terra.StrengthPositionVariant2? strengthPositionVariant2 = default;
            global::Terra.StrengthPositionVariant3? strengthPositionVariant3 = default;
            global::Terra.StrengthPositionVariant4? strengthPositionVariant4 = default;
            global::Terra.StrengthPositionVariant5? strengthPositionVariant5 = default;
            global::Terra.StrengthPositionVariant6? strengthPositionVariant6 = default;
            global::Terra.StrengthPositionVariant7? strengthPositionVariant7 = default;
            global::Terra.StrengthPositionVariant8? strengthPositionVariant8 = default;
            global::Terra.StrengthPositionVariant9? strengthPositionVariant9 = default;
            global::Terra.StrengthPositionVariant10? strengthPositionVariant10 = default;
            global::Terra.StrengthPositionVariant11? strengthPositionVariant11 = default;
            global::Terra.StrengthPositionVariant12? strengthPositionVariant12 = default;
            global::Terra.StrengthPositionVariant13? strengthPositionVariant13 = default;
            global::Terra.StrengthPositionVariant14? strengthPositionVariant14 = default;
            global::Terra.StrengthPositionVariant15? strengthPositionVariant15 = default;
            global::Terra.StrengthPositionVariant16? strengthPositionVariant16 = default;
            global::Terra.StrengthPositionVariant17? strengthPositionVariant17 = default;
            global::Terra.StrengthPositionVariant18? strengthPositionVariant18 = default;
            global::Terra.StrengthPositionVariant19? strengthPositionVariant19 = default;
            string? strengthPositionVariant20 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant1).Name}");
                        strengthPositionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant2).Name}");
                        strengthPositionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant3).Name}");
                        strengthPositionVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant4).Name}");
                        strengthPositionVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant5).Name}");
                        strengthPositionVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant6).Name}");
                        strengthPositionVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant7).Name}");
                        strengthPositionVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant8).Name}");
                        strengthPositionVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant9).Name}");
                        strengthPositionVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant10).Name}");
                        strengthPositionVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant11).Name}");
                        strengthPositionVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant12).Name}");
                        strengthPositionVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant13).Name}");
                        strengthPositionVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant14).Name}");
                        strengthPositionVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant15).Name}");
                        strengthPositionVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant16).Name}");
                        strengthPositionVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant17).Name}");
                        strengthPositionVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 17)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant18> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant18).Name}");
                        strengthPositionVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 18)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant19> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant19).Name}");
                        strengthPositionVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 19)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        strengthPositionVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant1).Name}");
                    strengthPositionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant2).Name}");
                    strengthPositionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant3).Name}");
                    strengthPositionVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant4).Name}");
                    strengthPositionVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant5).Name}");
                    strengthPositionVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant6).Name}");
                    strengthPositionVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant7).Name}");
                    strengthPositionVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant8).Name}");
                    strengthPositionVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant9).Name}");
                    strengthPositionVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant10).Name}");
                    strengthPositionVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant11).Name}");
                    strengthPositionVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant12).Name}");
                    strengthPositionVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant13).Name}");
                    strengthPositionVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant14).Name}");
                    strengthPositionVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant15).Name}");
                    strengthPositionVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant16).Name}");
                    strengthPositionVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant17).Name}");
                    strengthPositionVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant18> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant18).Name}");
                    strengthPositionVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant19> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant19).Name}");
                    strengthPositionVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthPositionVariant1 == null && strengthPositionVariant2 == null && strengthPositionVariant3 == null && strengthPositionVariant4 == null && strengthPositionVariant5 == null && strengthPositionVariant6 == null && strengthPositionVariant7 == null && strengthPositionVariant8 == null && strengthPositionVariant9 == null && strengthPositionVariant10 == null && strengthPositionVariant11 == null && strengthPositionVariant12 == null && strengthPositionVariant13 == null && strengthPositionVariant14 == null && strengthPositionVariant15 == null && strengthPositionVariant16 == null && strengthPositionVariant17 == null && strengthPositionVariant18 == null && strengthPositionVariant19 == null && strengthPositionVariant20 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    strengthPositionVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.StrengthPosition(
                strengthPositionVariant1,

                strengthPositionVariant2,

                strengthPositionVariant3,

                strengthPositionVariant4,

                strengthPositionVariant5,

                strengthPositionVariant6,

                strengthPositionVariant7,

                strengthPositionVariant8,

                strengthPositionVariant9,

                strengthPositionVariant10,

                strengthPositionVariant11,

                strengthPositionVariant12,

                strengthPositionVariant13,

                strengthPositionVariant14,

                strengthPositionVariant15,

                strengthPositionVariant16,

                strengthPositionVariant17,

                strengthPositionVariant18,

                strengthPositionVariant19,

                strengthPositionVariant20
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.StrengthPosition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStrengthPositionVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant1!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant2!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant3!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant4!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant5!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant6!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant7!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant8!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant9!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant10!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant11!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant12!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant13!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant14!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant15!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant16!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant17!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant18!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPositionVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPositionVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPositionVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant19!.Value, typeInfo);
            }
            else if (value.IsStrengthPositionVariant20)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPositionVariant20!, typeInfo);
            }
        }
    }
}