#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class StrengthImplementJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.StrengthImplement>
    {
        /// <inheritdoc />
        public override global::Terra.StrengthImplement Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant8), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant9), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant10), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant11), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant12), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant13), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant14), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant15), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant16), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant17), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant18), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant19), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant20), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant21), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant22), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant23), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant24), options);
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

            global::Terra.StrengthImplementVariant1? strengthImplementVariant1 = default;
            global::Terra.StrengthImplementVariant2? strengthImplementVariant2 = default;
            global::Terra.StrengthImplementVariant3? strengthImplementVariant3 = default;
            global::Terra.StrengthImplementVariant4? strengthImplementVariant4 = default;
            global::Terra.StrengthImplementVariant5? strengthImplementVariant5 = default;
            global::Terra.StrengthImplementVariant6? strengthImplementVariant6 = default;
            global::Terra.StrengthImplementVariant7? strengthImplementVariant7 = default;
            global::Terra.StrengthImplementVariant8? strengthImplementVariant8 = default;
            global::Terra.StrengthImplementVariant9? strengthImplementVariant9 = default;
            global::Terra.StrengthImplementVariant10? strengthImplementVariant10 = default;
            global::Terra.StrengthImplementVariant11? strengthImplementVariant11 = default;
            global::Terra.StrengthImplementVariant12? strengthImplementVariant12 = default;
            global::Terra.StrengthImplementVariant13? strengthImplementVariant13 = default;
            global::Terra.StrengthImplementVariant14? strengthImplementVariant14 = default;
            global::Terra.StrengthImplementVariant15? strengthImplementVariant15 = default;
            global::Terra.StrengthImplementVariant16? strengthImplementVariant16 = default;
            global::Terra.StrengthImplementVariant17? strengthImplementVariant17 = default;
            global::Terra.StrengthImplementVariant18? strengthImplementVariant18 = default;
            global::Terra.StrengthImplementVariant19? strengthImplementVariant19 = default;
            global::Terra.StrengthImplementVariant20? strengthImplementVariant20 = default;
            global::Terra.StrengthImplementVariant21? strengthImplementVariant21 = default;
            global::Terra.StrengthImplementVariant22? strengthImplementVariant22 = default;
            global::Terra.StrengthImplementVariant23? strengthImplementVariant23 = default;
            global::Terra.StrengthImplementVariant24? strengthImplementVariant24 = default;
            string? strengthImplementVariant25 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant1).Name}");
                        strengthImplementVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant2).Name}");
                        strengthImplementVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant3).Name}");
                        strengthImplementVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant4).Name}");
                        strengthImplementVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant5).Name}");
                        strengthImplementVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant6).Name}");
                        strengthImplementVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant7).Name}");
                        strengthImplementVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant8).Name}");
                        strengthImplementVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant9).Name}");
                        strengthImplementVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant10).Name}");
                        strengthImplementVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant11).Name}");
                        strengthImplementVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant12).Name}");
                        strengthImplementVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant13).Name}");
                        strengthImplementVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant14).Name}");
                        strengthImplementVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant15).Name}");
                        strengthImplementVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant16).Name}");
                        strengthImplementVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant17).Name}");
                        strengthImplementVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant18> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant18).Name}");
                        strengthImplementVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant19> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant19).Name}");
                        strengthImplementVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant20> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant20).Name}");
                        strengthImplementVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant21> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant21).Name}");
                        strengthImplementVariant21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant22> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant22).Name}");
                        strengthImplementVariant22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant23> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant23).Name}");
                        strengthImplementVariant23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant24> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant24).Name}");
                        strengthImplementVariant24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        strengthImplementVariant25 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant1).Name}");
                    strengthImplementVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant2).Name}");
                    strengthImplementVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant3).Name}");
                    strengthImplementVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant4).Name}");
                    strengthImplementVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant5).Name}");
                    strengthImplementVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant6).Name}");
                    strengthImplementVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant7).Name}");
                    strengthImplementVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant8).Name}");
                    strengthImplementVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant9).Name}");
                    strengthImplementVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant10).Name}");
                    strengthImplementVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant11).Name}");
                    strengthImplementVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant12).Name}");
                    strengthImplementVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant13).Name}");
                    strengthImplementVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant14).Name}");
                    strengthImplementVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant15).Name}");
                    strengthImplementVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant16).Name}");
                    strengthImplementVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant17).Name}");
                    strengthImplementVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant18> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant18).Name}");
                    strengthImplementVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant19> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant19).Name}");
                    strengthImplementVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant20> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant20).Name}");
                    strengthImplementVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant21> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant21).Name}");
                    strengthImplementVariant21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant22> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant22).Name}");
                    strengthImplementVariant22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant23> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant23).Name}");
                    strengthImplementVariant23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant24> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant24).Name}");
                    strengthImplementVariant24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthImplementVariant1 == null && strengthImplementVariant2 == null && strengthImplementVariant3 == null && strengthImplementVariant4 == null && strengthImplementVariant5 == null && strengthImplementVariant6 == null && strengthImplementVariant7 == null && strengthImplementVariant8 == null && strengthImplementVariant9 == null && strengthImplementVariant10 == null && strengthImplementVariant11 == null && strengthImplementVariant12 == null && strengthImplementVariant13 == null && strengthImplementVariant14 == null && strengthImplementVariant15 == null && strengthImplementVariant16 == null && strengthImplementVariant17 == null && strengthImplementVariant18 == null && strengthImplementVariant19 == null && strengthImplementVariant20 == null && strengthImplementVariant21 == null && strengthImplementVariant22 == null && strengthImplementVariant23 == null && strengthImplementVariant24 == null && strengthImplementVariant25 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    strengthImplementVariant25 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.StrengthImplement(
                strengthImplementVariant1,

                strengthImplementVariant2,

                strengthImplementVariant3,

                strengthImplementVariant4,

                strengthImplementVariant5,

                strengthImplementVariant6,

                strengthImplementVariant7,

                strengthImplementVariant8,

                strengthImplementVariant9,

                strengthImplementVariant10,

                strengthImplementVariant11,

                strengthImplementVariant12,

                strengthImplementVariant13,

                strengthImplementVariant14,

                strengthImplementVariant15,

                strengthImplementVariant16,

                strengthImplementVariant17,

                strengthImplementVariant18,

                strengthImplementVariant19,

                strengthImplementVariant20,

                strengthImplementVariant21,

                strengthImplementVariant22,

                strengthImplementVariant23,

                strengthImplementVariant24,

                strengthImplementVariant25
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.StrengthImplement value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStrengthImplementVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant1!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant2!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant3!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant4!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant5!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant6!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant7!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant8!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant9!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant10!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant11!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant12!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant13!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant14!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant15!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant16!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant17!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant18!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant19!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant20)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant20> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant20!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant21)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant21> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant21!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant22)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant22> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant22).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant22!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant23)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant23> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant23).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant23!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant24)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthImplementVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthImplementVariant24> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthImplementVariant24).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant24!.Value, typeInfo);
            }
            else if (value.IsStrengthImplementVariant25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthImplementVariant25!, typeInfo);
            }
        }
    }
}