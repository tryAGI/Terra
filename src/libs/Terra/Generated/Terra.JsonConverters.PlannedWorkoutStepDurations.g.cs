#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class PlannedWorkoutStepDurationsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.PlannedWorkoutStepDurations>
    {
        /// <inheritdoc />
        public override global::Terra.PlannedWorkoutStepDurations Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutStepDurationsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutStepDurationsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PlannedWorkoutStepDurationsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Terra.PlannedWorkoutStepDuration? plannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.PlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PlannedWorkoutStepDuration)}");
                plannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.TimePlannedWorkoutStepDuration? timePlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.TimePlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.TimePlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.TimePlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.TimePlannedWorkoutStepDuration)}");
                timePlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.PowerAbovePlannedWorkoutStepDuration? powerAbovePlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.PowerAbovePlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PowerAbovePlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PowerAbovePlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PowerAbovePlannedWorkoutStepDuration)}");
                powerAbovePlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.PowerBelowPlannedWorkoutStepDuration? powerBelowPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.PowerBelowPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PowerBelowPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PowerBelowPlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PowerBelowPlannedWorkoutStepDuration)}");
                powerBelowPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.FixedRestPlannedWorkoutStepDuration? fixedRestPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.FixedRestPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.FixedRestPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.FixedRestPlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.FixedRestPlannedWorkoutStepDuration)}");
                fixedRestPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.CaloriesPlannedWorkoutStepDuration? caloriesPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.CaloriesPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CaloriesPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CaloriesPlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.CaloriesPlannedWorkoutStepDuration)}");
                caloriesPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.HRAbovePlannedWorkoutStepDuration? hRAbovePlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.HRAbovePlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.HRAbovePlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.HRAbovePlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.HRAbovePlannedWorkoutStepDuration)}");
                hRAbovePlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.HRBelowPlannedWorkoutStepDuration? hRBelowPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.HRBelowPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.HRBelowPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.HRBelowPlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.HRBelowPlannedWorkoutStepDuration)}");
                hRBelowPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.RepsPlannedWorkoutStepDuration? repsPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.RepsPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.RepsPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.RepsPlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.RepsPlannedWorkoutStepDuration)}");
                repsPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.DistancePlannedWorkoutStepDuration? distancePlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.DistancePlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.DistancePlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.DistancePlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.DistancePlannedWorkoutStepDuration)}");
                distancePlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.StepsPlannedWorkoutStepDuration? stepsPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.StepsPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StepsPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StepsPlannedWorkoutStepDuration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.StepsPlannedWorkoutStepDuration)}");
                stepsPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Terra.PlannedWorkoutStepDurations(
                discriminator?.Type,
                plannedWorkoutStepDuration,

                timePlannedWorkoutStepDuration,

                powerAbovePlannedWorkoutStepDuration,

                powerBelowPlannedWorkoutStepDuration,

                fixedRestPlannedWorkoutStepDuration,

                caloriesPlannedWorkoutStepDuration,

                hRAbovePlannedWorkoutStepDuration,

                hRBelowPlannedWorkoutStepDuration,

                repsPlannedWorkoutStepDuration,

                distancePlannedWorkoutStepDuration,

                stepsPlannedWorkoutStepDuration
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.PlannedWorkoutStepDurations value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsTimePlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.TimePlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.TimePlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.TimePlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimePlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsPowerAbovePlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PowerAbovePlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PowerAbovePlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PowerAbovePlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PowerAbovePlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsPowerBelowPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PowerBelowPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PowerBelowPlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PowerBelowPlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PowerBelowPlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsFixedRestPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.FixedRestPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.FixedRestPlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.FixedRestPlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FixedRestPlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsCaloriesPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CaloriesPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CaloriesPlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CaloriesPlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CaloriesPlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsHRAbovePlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.HRAbovePlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.HRAbovePlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.HRAbovePlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HRAbovePlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsHRBelowPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.HRBelowPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.HRBelowPlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.HRBelowPlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HRBelowPlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsRepsPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.RepsPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.RepsPlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.RepsPlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepsPlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsDistancePlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.DistancePlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.DistancePlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.DistancePlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DistancePlannedWorkoutStepDuration!, typeInfo);
            }
            else if (value.IsStepsPlannedWorkoutStepDuration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StepsPlannedWorkoutStepDuration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StepsPlannedWorkoutStepDuration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StepsPlannedWorkoutStepDuration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepsPlannedWorkoutStepDuration!, typeInfo);
            }
        }
    }
}