#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class PlannedWorkoutStepsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.PlannedWorkoutSteps>
    {
        /// <inheritdoc />
        public override global::Terra.PlannedWorkoutSteps Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutStepsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutStepsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PlannedWorkoutStepsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Terra.PlannedWorkoutStep? plannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.PlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PlannedWorkoutStep)}");
                plannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.PlannedWorkoutRepeatStep? plannedWorkoutRepeatStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.PlannedWorkoutRepeatStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutRepeatStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutRepeatStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PlannedWorkoutRepeatStep)}");
                plannedWorkoutRepeatStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.SwimmingPlannedWorkoutStep? swimmingPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.SwimmingPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimmingPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimmingPlannedWorkoutStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.SwimmingPlannedWorkoutStep)}");
                swimmingPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.CardioPlannedWorkoutStep? cardioPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.CardioPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CardioPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CardioPlannedWorkoutStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.CardioPlannedWorkoutStep)}");
                cardioPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.StrengthPlannedWorkoutStep? strengthPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.StrengthPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPlannedWorkoutStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.StrengthPlannedWorkoutStep)}");
                strengthPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.YogaPlannedWorkoutStep? yogaPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.YogaPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.YogaPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.YogaPlannedWorkoutStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.YogaPlannedWorkoutStep)}");
                yogaPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.PilatesPlannedWorkoutStep? pilatesPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.PilatesPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PilatesPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PilatesPlannedWorkoutStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.PilatesPlannedWorkoutStep)}");
                pilatesPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.RunningPlannedWorkoutStep? runningPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.RunningPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.RunningPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.RunningPlannedWorkoutStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.RunningPlannedWorkoutStep)}");
                runningPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Terra.CyclingPlannedWorkoutStep? cyclingPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.CyclingPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CyclingPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CyclingPlannedWorkoutStep> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Terra.CyclingPlannedWorkoutStep)}");
                cyclingPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Terra.PlannedWorkoutSteps(
                discriminator?.Type,
                plannedWorkoutStep,

                plannedWorkoutRepeatStep,

                swimmingPlannedWorkoutStep,

                cardioPlannedWorkoutStep,

                strengthPlannedWorkoutStep,

                yogaPlannedWorkoutStep,

                pilatesPlannedWorkoutStep,

                runningPlannedWorkoutStep,

                cyclingPlannedWorkoutStep
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.PlannedWorkoutSteps value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PlannedWorkoutStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlannedWorkoutStep!, typeInfo);
            }
            else if (value.IsPlannedWorkoutRepeatStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PlannedWorkoutRepeatStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PlannedWorkoutRepeatStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PlannedWorkoutRepeatStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlannedWorkoutRepeatStep!, typeInfo);
            }
            else if (value.IsSwimmingPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.SwimmingPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.SwimmingPlannedWorkoutStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.SwimmingPlannedWorkoutStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimmingPlannedWorkoutStep!, typeInfo);
            }
            else if (value.IsCardioPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CardioPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CardioPlannedWorkoutStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CardioPlannedWorkoutStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CardioPlannedWorkoutStep!, typeInfo);
            }
            else if (value.IsStrengthPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.StrengthPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.StrengthPlannedWorkoutStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.StrengthPlannedWorkoutStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPlannedWorkoutStep!, typeInfo);
            }
            else if (value.IsYogaPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.YogaPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.YogaPlannedWorkoutStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.YogaPlannedWorkoutStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.YogaPlannedWorkoutStep!, typeInfo);
            }
            else if (value.IsPilatesPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.PilatesPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.PilatesPlannedWorkoutStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.PilatesPlannedWorkoutStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PilatesPlannedWorkoutStep!, typeInfo);
            }
            else if (value.IsRunningPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.RunningPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.RunningPlannedWorkoutStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.RunningPlannedWorkoutStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunningPlannedWorkoutStep!, typeInfo);
            }
            else if (value.IsCyclingPlannedWorkoutStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Terra.CyclingPlannedWorkoutStep), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Terra.CyclingPlannedWorkoutStep?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Terra.CyclingPlannedWorkoutStep).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CyclingPlannedWorkoutStep!, typeInfo);
            }
        }
    }
}