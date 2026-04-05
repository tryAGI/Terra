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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PlannedWorkoutStepsDiscriminator>(ref readerCopy, options);

            global::Terra.PlannedWorkoutStep? plannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.PlannedWorkoutStep)
            {
                plannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PlannedWorkoutStep>(ref reader, options);
            }
            global::Terra.PlannedWorkoutRepeatStep? plannedWorkoutRepeatStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.PlannedWorkoutRepeatStep)
            {
                plannedWorkoutRepeatStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PlannedWorkoutRepeatStep>(ref reader, options);
            }
            global::Terra.SwimmingPlannedWorkoutStep? swimmingPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.SwimmingPlannedWorkoutStep)
            {
                swimmingPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.SwimmingPlannedWorkoutStep>(ref reader, options);
            }
            global::Terra.CardioPlannedWorkoutStep? cardioPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.CardioPlannedWorkoutStep)
            {
                cardioPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.CardioPlannedWorkoutStep>(ref reader, options);
            }
            global::Terra.StrengthPlannedWorkoutStep? strengthPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.StrengthPlannedWorkoutStep)
            {
                strengthPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.StrengthPlannedWorkoutStep>(ref reader, options);
            }
            global::Terra.YogaPlannedWorkoutStep? yogaPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.YogaPlannedWorkoutStep)
            {
                yogaPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.YogaPlannedWorkoutStep>(ref reader, options);
            }
            global::Terra.PilatesPlannedWorkoutStep? pilatesPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.PilatesPlannedWorkoutStep)
            {
                pilatesPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PilatesPlannedWorkoutStep>(ref reader, options);
            }
            global::Terra.RunningPlannedWorkoutStep? runningPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.RunningPlannedWorkoutStep)
            {
                runningPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.RunningPlannedWorkoutStep>(ref reader, options);
            }
            global::Terra.CyclingPlannedWorkoutStep? cyclingPlannedWorkoutStep = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepsDiscriminatorType.CyclingPlannedWorkoutStep)
            {
                cyclingPlannedWorkoutStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.CyclingPlannedWorkoutStep>(ref reader, options);
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

            if (value.IsPlannedWorkoutStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlannedWorkoutStep, typeof(global::Terra.PlannedWorkoutStep), options);
            }
            else if (value.IsPlannedWorkoutRepeatStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlannedWorkoutRepeatStep, typeof(global::Terra.PlannedWorkoutRepeatStep), options);
            }
            else if (value.IsSwimmingPlannedWorkoutStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimmingPlannedWorkoutStep, typeof(global::Terra.SwimmingPlannedWorkoutStep), options);
            }
            else if (value.IsCardioPlannedWorkoutStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CardioPlannedWorkoutStep, typeof(global::Terra.CardioPlannedWorkoutStep), options);
            }
            else if (value.IsStrengthPlannedWorkoutStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StrengthPlannedWorkoutStep, typeof(global::Terra.StrengthPlannedWorkoutStep), options);
            }
            else if (value.IsYogaPlannedWorkoutStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.YogaPlannedWorkoutStep, typeof(global::Terra.YogaPlannedWorkoutStep), options);
            }
            else if (value.IsPilatesPlannedWorkoutStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PilatesPlannedWorkoutStep, typeof(global::Terra.PilatesPlannedWorkoutStep), options);
            }
            else if (value.IsRunningPlannedWorkoutStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunningPlannedWorkoutStep, typeof(global::Terra.RunningPlannedWorkoutStep), options);
            }
            else if (value.IsCyclingPlannedWorkoutStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CyclingPlannedWorkoutStep, typeof(global::Terra.CyclingPlannedWorkoutStep), options);
            }
        }
    }
}