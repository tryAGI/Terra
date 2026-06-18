#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class WorkoutSportJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.WorkoutSport>
    {
        /// <inheritdoc />
        public override global::Terra.WorkoutSport Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant2), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant3), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant4), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant5), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant6), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant7), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant8), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant9), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant10), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant11), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant12), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant13), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant14), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant15), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score14++;
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

            global::Terra.WorkoutSportVariant1? workoutSportVariant1 = default;
            global::Terra.WorkoutSportVariant2? workoutSportVariant2 = default;
            global::Terra.WorkoutSportVariant3? workoutSportVariant3 = default;
            global::Terra.WorkoutSportVariant4? workoutSportVariant4 = default;
            global::Terra.WorkoutSportVariant5? workoutSportVariant5 = default;
            global::Terra.WorkoutSportVariant6? workoutSportVariant6 = default;
            global::Terra.WorkoutSportVariant7? workoutSportVariant7 = default;
            global::Terra.WorkoutSportVariant8? workoutSportVariant8 = default;
            global::Terra.WorkoutSportVariant9? workoutSportVariant9 = default;
            global::Terra.WorkoutSportVariant10? workoutSportVariant10 = default;
            global::Terra.WorkoutSportVariant11? workoutSportVariant11 = default;
            global::Terra.WorkoutSportVariant12? workoutSportVariant12 = default;
            global::Terra.WorkoutSportVariant13? workoutSportVariant13 = default;
            global::Terra.WorkoutSportVariant14? workoutSportVariant14 = default;
            global::Terra.WorkoutSportVariant15? workoutSportVariant15 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant1).Name}");
                        workoutSportVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant2).Name}");
                        workoutSportVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant3).Name}");
                        workoutSportVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant4).Name}");
                        workoutSportVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant5).Name}");
                        workoutSportVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant6).Name}");
                        workoutSportVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant7).Name}");
                        workoutSportVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant8).Name}");
                        workoutSportVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant9).Name}");
                        workoutSportVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant10).Name}");
                        workoutSportVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant11).Name}");
                        workoutSportVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant12).Name}");
                        workoutSportVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant13).Name}");
                        workoutSportVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant14).Name}");
                        workoutSportVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant15).Name}");
                        workoutSportVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant1).Name}");
                    workoutSportVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant2).Name}");
                    workoutSportVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant3).Name}");
                    workoutSportVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant4).Name}");
                    workoutSportVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant5).Name}");
                    workoutSportVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant6).Name}");
                    workoutSportVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant7).Name}");
                    workoutSportVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant8).Name}");
                    workoutSportVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant9).Name}");
                    workoutSportVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant10).Name}");
                    workoutSportVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant11).Name}");
                    workoutSportVariant11 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant12).Name}");
                    workoutSportVariant12 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant13).Name}");
                    workoutSportVariant13 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant14).Name}");
                    workoutSportVariant14 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workoutSportVariant1 == null && workoutSportVariant2 == null && workoutSportVariant3 == null && workoutSportVariant4 == null && workoutSportVariant5 == null && workoutSportVariant6 == null && workoutSportVariant7 == null && workoutSportVariant8 == null && workoutSportVariant9 == null && workoutSportVariant10 == null && workoutSportVariant11 == null && workoutSportVariant12 == null && workoutSportVariant13 == null && workoutSportVariant14 == null && workoutSportVariant15 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant15).Name}");
                    workoutSportVariant15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Terra.WorkoutSport(
                workoutSportVariant1,

                workoutSportVariant2,

                workoutSportVariant3,

                workoutSportVariant4,

                workoutSportVariant5,

                workoutSportVariant6,

                workoutSportVariant7,

                workoutSportVariant8,

                workoutSportVariant9,

                workoutSportVariant10,

                workoutSportVariant11,

                workoutSportVariant12,

                workoutSportVariant13,

                workoutSportVariant14,

                workoutSportVariant15
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.WorkoutSport value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkoutSportVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant1!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant2!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant3!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant4!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant5!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant6!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant7!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant8!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant9!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant10!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant11!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant12!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant13!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant14!.Value, typeInfo);
            }
            else if (value.IsWorkoutSportVariant15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.WorkoutSportVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.WorkoutSportVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.WorkoutSportVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkoutSportVariant15!.Value, typeInfo);
            }
        }
    }
}