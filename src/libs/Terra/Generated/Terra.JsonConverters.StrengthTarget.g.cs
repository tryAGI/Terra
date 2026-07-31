#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class StrengthTargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.StrengthTarget>
    {
        /// <inheritdoc />
        public override global::Terra.StrengthTarget Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant8), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant9), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant10), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant11), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant12), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant13), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant14), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant15), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant16), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant17), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant18), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant19), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant20), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score19++;
                    }
                }
            }
            var __score20 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant21), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score20++;
                    }
                }
            }
            var __score21 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant22), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score21++;
                    }
                }
            }
            var __score22 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant23), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score22++;
                    }
                }
            }
            var __score23 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant24), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score23++;
                    }
                }
            }
            var __score24 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(string), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score24++;
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
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }

            global::Terra.StrengthTargetVariant1? strengthTargetVariant1 = default;
            global::Terra.StrengthTargetVariant2? strengthTargetVariant2 = default;
            global::Terra.StrengthTargetVariant3? strengthTargetVariant3 = default;
            global::Terra.StrengthTargetVariant4? strengthTargetVariant4 = default;
            global::Terra.StrengthTargetVariant5? strengthTargetVariant5 = default;
            global::Terra.StrengthTargetVariant6? strengthTargetVariant6 = default;
            global::Terra.StrengthTargetVariant7? strengthTargetVariant7 = default;
            global::Terra.StrengthTargetVariant8? strengthTargetVariant8 = default;
            global::Terra.StrengthTargetVariant9? strengthTargetVariant9 = default;
            global::Terra.StrengthTargetVariant10? strengthTargetVariant10 = default;
            global::Terra.StrengthTargetVariant11? strengthTargetVariant11 = default;
            global::Terra.StrengthTargetVariant12? strengthTargetVariant12 = default;
            global::Terra.StrengthTargetVariant13? strengthTargetVariant13 = default;
            global::Terra.StrengthTargetVariant14? strengthTargetVariant14 = default;
            global::Terra.StrengthTargetVariant15? strengthTargetVariant15 = default;
            global::Terra.StrengthTargetVariant16? strengthTargetVariant16 = default;
            global::Terra.StrengthTargetVariant17? strengthTargetVariant17 = default;
            global::Terra.StrengthTargetVariant18? strengthTargetVariant18 = default;
            global::Terra.StrengthTargetVariant19? strengthTargetVariant19 = default;
            global::Terra.StrengthTargetVariant20? strengthTargetVariant20 = default;
            global::Terra.StrengthTargetVariant21? strengthTargetVariant21 = default;
            global::Terra.StrengthTargetVariant22? strengthTargetVariant22 = default;
            global::Terra.StrengthTargetVariant23? strengthTargetVariant23 = default;
            global::Terra.StrengthTargetVariant24? strengthTargetVariant24 = default;
            string? strengthTargetVariant25 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant1).Name}");
                        strengthTargetVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant2).Name}");
                        strengthTargetVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant3).Name}");
                        strengthTargetVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant4).Name}");
                        strengthTargetVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant5).Name}");
                        strengthTargetVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant6).Name}");
                        strengthTargetVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant7).Name}");
                        strengthTargetVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant8).Name}");
                        strengthTargetVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant9).Name}");
                        strengthTargetVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant10).Name}");
                        strengthTargetVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant11).Name}");
                        strengthTargetVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant12).Name}");
                        strengthTargetVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant13).Name}");
                        strengthTargetVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant14).Name}");
                        strengthTargetVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant15).Name}");
                        strengthTargetVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant16).Name}");
                        strengthTargetVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant17).Name}");
                        strengthTargetVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant18> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant18).Name}");
                        strengthTargetVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant19> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant19).Name}");
                        strengthTargetVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant20> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant20).Name}");
                        strengthTargetVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 20)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant21> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant21).Name}");
                        strengthTargetVariant21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 21)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant22> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant22).Name}");
                        strengthTargetVariant22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 22)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant23> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant23).Name}");
                        strengthTargetVariant23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 23)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant24> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant24).Name}");
                        strengthTargetVariant24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 24)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        strengthTargetVariant25 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant1).Name}");
                    strengthTargetVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant2).Name}");
                    strengthTargetVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant3).Name}");
                    strengthTargetVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant4).Name}");
                    strengthTargetVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant5).Name}");
                    strengthTargetVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant6).Name}");
                    strengthTargetVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant7).Name}");
                    strengthTargetVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant8).Name}");
                    strengthTargetVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant9).Name}");
                    strengthTargetVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant10).Name}");
                    strengthTargetVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant11).Name}");
                    strengthTargetVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant12).Name}");
                    strengthTargetVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant13).Name}");
                    strengthTargetVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant14).Name}");
                    strengthTargetVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant15).Name}");
                    strengthTargetVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant16).Name}");
                    strengthTargetVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant17).Name}");
                    strengthTargetVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant18> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant18).Name}");
                    strengthTargetVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant19> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant19).Name}");
                    strengthTargetVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant20> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant20).Name}");
                    strengthTargetVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant21> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant21).Name}");
                    strengthTargetVariant21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant22> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant22).Name}");
                    strengthTargetVariant22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant23> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant23).Name}");
                    strengthTargetVariant23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant24> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant24).Name}");
                    strengthTargetVariant24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthTargetVariant1 == null && strengthTargetVariant2 == null && strengthTargetVariant3 == null && strengthTargetVariant4 == null && strengthTargetVariant5 == null && strengthTargetVariant6 == null && strengthTargetVariant7 == null && strengthTargetVariant8 == null && strengthTargetVariant9 == null && strengthTargetVariant10 == null && strengthTargetVariant11 == null && strengthTargetVariant12 == null && strengthTargetVariant13 == null && strengthTargetVariant14 == null && strengthTargetVariant15 == null && strengthTargetVariant16 == null && strengthTargetVariant17 == null && strengthTargetVariant18 == null && strengthTargetVariant19 == null && strengthTargetVariant20 == null && strengthTargetVariant21 == null && strengthTargetVariant22 == null && strengthTargetVariant23 == null && strengthTargetVariant24 == null && strengthTargetVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    strengthTargetVariant25 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.StrengthTarget(
                strengthTargetVariant1,

                strengthTargetVariant2,

                strengthTargetVariant3,

                strengthTargetVariant4,

                strengthTargetVariant5,

                strengthTargetVariant6,

                strengthTargetVariant7,

                strengthTargetVariant8,

                strengthTargetVariant9,

                strengthTargetVariant10,

                strengthTargetVariant11,

                strengthTargetVariant12,

                strengthTargetVariant13,

                strengthTargetVariant14,

                strengthTargetVariant15,

                strengthTargetVariant16,

                strengthTargetVariant17,

                strengthTargetVariant18,

                strengthTargetVariant19,

                strengthTargetVariant20,

                strengthTargetVariant21,

                strengthTargetVariant22,

                strengthTargetVariant23,

                strengthTargetVariant24,

                strengthTargetVariant25
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.StrengthTarget value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStrengthTargetVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant1!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant2!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant3!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant4!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant5!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant6!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant7!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant8!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant9!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant10!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant11!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant12!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant13!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant14!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant15!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant16!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant17!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant18!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant19!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant20)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant20> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant20!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant21)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant21> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant21!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant22)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant22> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant22).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant22!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant23)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant23> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant23).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant23!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant24)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthTargetVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthTargetVariant24> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthTargetVariant24).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant24!.Value, typeInfo);
            }
            else if (value.IsStrengthTargetVariant25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthTargetVariant25!, typeInfo);
            }
        }
    }
}