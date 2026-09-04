#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class WorkoutStepTargetTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.WorkoutStepTargetType>
    {
        /// <inheritdoc />
        public override global::Terra.WorkoutStepTargetType Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant8), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant9), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant10), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant11), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant12), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant13), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant14), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant15), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant16), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant17), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant18), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant19), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score18++;
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

            global::Terra.WorkoutStepTargetTypeVariant1? workoutStepTargetTypeVariant1 = default;
            global::Terra.WorkoutStepTargetTypeVariant2? workoutStepTargetTypeVariant2 = default;
            global::Terra.WorkoutStepTargetTypeVariant3? workoutStepTargetTypeVariant3 = default;
            global::Terra.WorkoutStepTargetTypeVariant4? workoutStepTargetTypeVariant4 = default;
            global::Terra.WorkoutStepTargetTypeVariant5? workoutStepTargetTypeVariant5 = default;
            global::Terra.WorkoutStepTargetTypeVariant6? workoutStepTargetTypeVariant6 = default;
            global::Terra.WorkoutStepTargetTypeVariant7? workoutStepTargetTypeVariant7 = default;
            global::Terra.WorkoutStepTargetTypeVariant8? workoutStepTargetTypeVariant8 = default;
            global::Terra.WorkoutStepTargetTypeVariant9? workoutStepTargetTypeVariant9 = default;
            global::Terra.WorkoutStepTargetTypeVariant10? workoutStepTargetTypeVariant10 = default;
            global::Terra.WorkoutStepTargetTypeVariant11? workoutStepTargetTypeVariant11 = default;
            global::Terra.WorkoutStepTargetTypeVariant12? workoutStepTargetTypeVariant12 = default;
            global::Terra.WorkoutStepTargetTypeVariant13? workoutStepTargetTypeVariant13 = default;
            global::Terra.WorkoutStepTargetTypeVariant14? workoutStepTargetTypeVariant14 = default;
            global::Terra.WorkoutStepTargetTypeVariant15? workoutStepTargetTypeVariant15 = default;
            global::Terra.WorkoutStepTargetTypeVariant16? workoutStepTargetTypeVariant16 = default;
            global::Terra.WorkoutStepTargetTypeVariant17? workoutStepTargetTypeVariant17 = default;
            global::Terra.WorkoutStepTargetTypeVariant18? workoutStepTargetTypeVariant18 = default;
            global::Terra.WorkoutStepTargetTypeVariant19? workoutStepTargetTypeVariant19 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant1).Name}");
                        workoutStepTargetTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant2).Name}");
                        workoutStepTargetTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant3).Name}");
                        workoutStepTargetTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant4).Name}");
                        workoutStepTargetTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant5).Name}");
                        workoutStepTargetTypeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant6).Name}");
                        workoutStepTargetTypeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant7).Name}");
                        workoutStepTargetTypeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant8).Name}");
                        workoutStepTargetTypeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant9).Name}");
                        workoutStepTargetTypeVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant10).Name}");
                        workoutStepTargetTypeVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant11).Name}");
                        workoutStepTargetTypeVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant12).Name}");
                        workoutStepTargetTypeVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant13).Name}");
                        workoutStepTargetTypeVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant14).Name}");
                        workoutStepTargetTypeVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant15).Name}");
                        workoutStepTargetTypeVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant16).Name}");
                        workoutStepTargetTypeVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant17).Name}");
                        workoutStepTargetTypeVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant18> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant18).Name}");
                        workoutStepTargetTypeVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant19> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant19).Name}");
                        workoutStepTargetTypeVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant1).Name}");
                    workoutStepTargetTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant2).Name}");
                    workoutStepTargetTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant3).Name}");
                    workoutStepTargetTypeVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant4).Name}");
                    workoutStepTargetTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant5).Name}");
                    workoutStepTargetTypeVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant6).Name}");
                    workoutStepTargetTypeVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant7).Name}");
                    workoutStepTargetTypeVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant8).Name}");
                    workoutStepTargetTypeVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant9).Name}");
                    workoutStepTargetTypeVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant10).Name}");
                    workoutStepTargetTypeVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant11).Name}");
                    workoutStepTargetTypeVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant12).Name}");
                    workoutStepTargetTypeVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant13).Name}");
                    workoutStepTargetTypeVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant14).Name}");
                    workoutStepTargetTypeVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant15).Name}");
                    workoutStepTargetTypeVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant16).Name}");
                    workoutStepTargetTypeVariant16 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant17).Name}");
                    workoutStepTargetTypeVariant17 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant18> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant18).Name}");
                    workoutStepTargetTypeVariant18 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutStepTargetTypeVariant1 == null && workoutStepTargetTypeVariant2 == null && workoutStepTargetTypeVariant3 == null && workoutStepTargetTypeVariant4 == null && workoutStepTargetTypeVariant5 == null && workoutStepTargetTypeVariant6 == null && workoutStepTargetTypeVariant7 == null && workoutStepTargetTypeVariant8 == null && workoutStepTargetTypeVariant9 == null && workoutStepTargetTypeVariant10 == null && workoutStepTargetTypeVariant11 == null && workoutStepTargetTypeVariant12 == null && workoutStepTargetTypeVariant13 == null && workoutStepTargetTypeVariant14 == null && workoutStepTargetTypeVariant15 == null && workoutStepTargetTypeVariant16 == null && workoutStepTargetTypeVariant17 == null && workoutStepTargetTypeVariant18 == null && workoutStepTargetTypeVariant19 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant19> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant19).Name}");
                    workoutStepTargetTypeVariant19 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.WorkoutStepTargetType(
                workoutStepTargetTypeVariant1,

                workoutStepTargetTypeVariant2,

                workoutStepTargetTypeVariant3,

                workoutStepTargetTypeVariant4,

                workoutStepTargetTypeVariant5,

                workoutStepTargetTypeVariant6,

                workoutStepTargetTypeVariant7,

                workoutStepTargetTypeVariant8,

                workoutStepTargetTypeVariant9,

                workoutStepTargetTypeVariant10,

                workoutStepTargetTypeVariant11,

                workoutStepTargetTypeVariant12,

                workoutStepTargetTypeVariant13,

                workoutStepTargetTypeVariant14,

                workoutStepTargetTypeVariant15,

                workoutStepTargetTypeVariant16,

                workoutStepTargetTypeVariant17,

                workoutStepTargetTypeVariant18,

                workoutStepTargetTypeVariant19
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.WorkoutStepTargetType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkoutStepTargetTypeVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant1!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant2!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant3!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant4!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant5!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant6!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant7!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant8!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant9!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant10!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant11!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant12!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant13!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant14!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant15!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant16!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant17!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant18!.Value, typeInfo);
            }
            else if (value.IsWorkoutStepTargetTypeVariant19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutStepTargetTypeVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutStepTargetTypeVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutStepTargetTypeVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutStepTargetTypeVariant19!.Value, typeInfo);
            }
        }
    }
}