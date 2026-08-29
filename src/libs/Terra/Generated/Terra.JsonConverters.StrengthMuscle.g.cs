#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class StrengthMuscleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.StrengthMuscle>
    {
        /// <inheritdoc />
        public override global::Terra.StrengthMuscle Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant8), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant9), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant10), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant11), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant12), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant13), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant14), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant15), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant16), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant17), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant18), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant19), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant20), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant21), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant22), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant23), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(string), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score23++;
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

            global::Terra.StrengthMuscleVariant1? strengthMuscleVariant1 = default;
            global::Terra.StrengthMuscleVariant2? strengthMuscleVariant2 = default;
            global::Terra.StrengthMuscleVariant3? strengthMuscleVariant3 = default;
            global::Terra.StrengthMuscleVariant4? strengthMuscleVariant4 = default;
            global::Terra.StrengthMuscleVariant5? strengthMuscleVariant5 = default;
            global::Terra.StrengthMuscleVariant6? strengthMuscleVariant6 = default;
            global::Terra.StrengthMuscleVariant7? strengthMuscleVariant7 = default;
            global::Terra.StrengthMuscleVariant8? strengthMuscleVariant8 = default;
            global::Terra.StrengthMuscleVariant9? strengthMuscleVariant9 = default;
            global::Terra.StrengthMuscleVariant10? strengthMuscleVariant10 = default;
            global::Terra.StrengthMuscleVariant11? strengthMuscleVariant11 = default;
            global::Terra.StrengthMuscleVariant12? strengthMuscleVariant12 = default;
            global::Terra.StrengthMuscleVariant13? strengthMuscleVariant13 = default;
            global::Terra.StrengthMuscleVariant14? strengthMuscleVariant14 = default;
            global::Terra.StrengthMuscleVariant15? strengthMuscleVariant15 = default;
            global::Terra.StrengthMuscleVariant16? strengthMuscleVariant16 = default;
            global::Terra.StrengthMuscleVariant17? strengthMuscleVariant17 = default;
            global::Terra.StrengthMuscleVariant18? strengthMuscleVariant18 = default;
            global::Terra.StrengthMuscleVariant19? strengthMuscleVariant19 = default;
            global::Terra.StrengthMuscleVariant20? strengthMuscleVariant20 = default;
            global::Terra.StrengthMuscleVariant21? strengthMuscleVariant21 = default;
            global::Terra.StrengthMuscleVariant22? strengthMuscleVariant22 = default;
            global::Terra.StrengthMuscleVariant23? strengthMuscleVariant23 = default;
            string? strengthMuscleVariant24 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant1).Name}");
                        strengthMuscleVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant2).Name}");
                        strengthMuscleVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant3).Name}");
                        strengthMuscleVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant4).Name}");
                        strengthMuscleVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant5).Name}");
                        strengthMuscleVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant6).Name}");
                        strengthMuscleVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant7).Name}");
                        strengthMuscleVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant8).Name}");
                        strengthMuscleVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant9).Name}");
                        strengthMuscleVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant10).Name}");
                        strengthMuscleVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant11).Name}");
                        strengthMuscleVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant12).Name}");
                        strengthMuscleVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant13).Name}");
                        strengthMuscleVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant14).Name}");
                        strengthMuscleVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant15).Name}");
                        strengthMuscleVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant16).Name}");
                        strengthMuscleVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant17).Name}");
                        strengthMuscleVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant18> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant18).Name}");
                        strengthMuscleVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant19> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant19).Name}");
                        strengthMuscleVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant20> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant20).Name}");
                        strengthMuscleVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant21> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant21).Name}");
                        strengthMuscleVariant21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant22> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant22).Name}");
                        strengthMuscleVariant22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant23> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant23).Name}");
                        strengthMuscleVariant23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        strengthMuscleVariant24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant1).Name}");
                    strengthMuscleVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant2).Name}");
                    strengthMuscleVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant3).Name}");
                    strengthMuscleVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant4).Name}");
                    strengthMuscleVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant5).Name}");
                    strengthMuscleVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant6).Name}");
                    strengthMuscleVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant7).Name}");
                    strengthMuscleVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant8).Name}");
                    strengthMuscleVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant9).Name}");
                    strengthMuscleVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant10).Name}");
                    strengthMuscleVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant11).Name}");
                    strengthMuscleVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant12).Name}");
                    strengthMuscleVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant13).Name}");
                    strengthMuscleVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant14).Name}");
                    strengthMuscleVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant15).Name}");
                    strengthMuscleVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant16).Name}");
                    strengthMuscleVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant17).Name}");
                    strengthMuscleVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant18> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant18).Name}");
                    strengthMuscleVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant19> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant19).Name}");
                    strengthMuscleVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant20> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant20).Name}");
                    strengthMuscleVariant20 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant21> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant21).Name}");
                    strengthMuscleVariant21 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant22> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant22).Name}");
                    strengthMuscleVariant22 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant23> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant23).Name}");
                    strengthMuscleVariant23 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (strengthMuscleVariant1 == null && strengthMuscleVariant2 == null && strengthMuscleVariant3 == null && strengthMuscleVariant4 == null && strengthMuscleVariant5 == null && strengthMuscleVariant6 == null && strengthMuscleVariant7 == null && strengthMuscleVariant8 == null && strengthMuscleVariant9 == null && strengthMuscleVariant10 == null && strengthMuscleVariant11 == null && strengthMuscleVariant12 == null && strengthMuscleVariant13 == null && strengthMuscleVariant14 == null && strengthMuscleVariant15 == null && strengthMuscleVariant16 == null && strengthMuscleVariant17 == null && strengthMuscleVariant18 == null && strengthMuscleVariant19 == null && strengthMuscleVariant20 == null && strengthMuscleVariant21 == null && strengthMuscleVariant22 == null && strengthMuscleVariant23 == null && strengthMuscleVariant24 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    strengthMuscleVariant24 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.StrengthMuscle(
                strengthMuscleVariant1,

                strengthMuscleVariant2,

                strengthMuscleVariant3,

                strengthMuscleVariant4,

                strengthMuscleVariant5,

                strengthMuscleVariant6,

                strengthMuscleVariant7,

                strengthMuscleVariant8,

                strengthMuscleVariant9,

                strengthMuscleVariant10,

                strengthMuscleVariant11,

                strengthMuscleVariant12,

                strengthMuscleVariant13,

                strengthMuscleVariant14,

                strengthMuscleVariant15,

                strengthMuscleVariant16,

                strengthMuscleVariant17,

                strengthMuscleVariant18,

                strengthMuscleVariant19,

                strengthMuscleVariant20,

                strengthMuscleVariant21,

                strengthMuscleVariant22,

                strengthMuscleVariant23,

                strengthMuscleVariant24
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.StrengthMuscle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStrengthMuscleVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant1!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant2!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant3!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant4!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant5!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant6!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant7!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant8!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant9!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant10!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant11!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant12!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant13!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant14!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant15!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant16!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant17!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant18!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant19!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant20)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant20> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant20!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant21)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant21> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant21!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant22)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant22> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant22).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant22!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant23)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthMuscleVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthMuscleVariant23> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthMuscleVariant23).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant23!.Value, typeInfo);
            }
            else if (value.IsStrengthMuscleVariant24)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthMuscleVariant24!, typeInfo);
            }
        }
    }
}