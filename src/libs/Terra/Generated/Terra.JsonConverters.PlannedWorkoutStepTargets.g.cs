#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public class PlannedWorkoutStepTargetsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.PlannedWorkoutStepTargets>
    {
        /// <inheritdoc />
        public override global::Terra.PlannedWorkoutStepTargets Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PlannedWorkoutStepTargetsDiscriminator>(ref readerCopy, options);

            global::Terra.PlannedWorkoutStepTarget? plannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.PlannedWorkoutStepTarget)
            {
                plannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PlannedWorkoutStepTarget>(ref reader, options);
            }
            global::Terra.CadencePlannedWorkoutStepTarget? cadencePlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.CadencePlannedWorkoutStepTarget)
            {
                cadencePlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.CadencePlannedWorkoutStepTarget>(ref reader, options);
            }
            global::Terra.HRPlannedWorkoutStepTarget? hRPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.HRPlannedWorkoutStepTarget)
            {
                hRPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.HRPlannedWorkoutStepTarget>(ref reader, options);
            }
            global::Terra.PowerPlannedWorkoutStepTarget? powerPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.PowerPlannedWorkoutStepTarget)
            {
                powerPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PowerPlannedWorkoutStepTarget>(ref reader, options);
            }
            global::Terra.SpeedPlannedWorkoutStepTarget? speedPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.SpeedPlannedWorkoutStepTarget)
            {
                speedPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.SpeedPlannedWorkoutStepTarget>(ref reader, options);
            }
            global::Terra.PacePlannedWorkoutStepTarget? pacePlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.PacePlannedWorkoutStepTarget)
            {
                pacePlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PacePlannedWorkoutStepTarget>(ref reader, options);
            }
            global::Terra.TSSPlannedWorkoutStepTarget? tSSPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.TSSPlannedWorkoutStepTarget)
            {
                tSSPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.TSSPlannedWorkoutStepTarget>(ref reader, options);
            }
            global::Terra.IFPlannedWorkoutStepTarget? iFPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.IFPlannedWorkoutStepTarget)
            {
                iFPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.IFPlannedWorkoutStepTarget>(ref reader, options);
            }
            global::Terra.RepetitionPlannedWorkoutStepTarget? repetitionPlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.RepetitionPlannedWorkoutStepTarget)
            {
                repetitionPlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.RepetitionPlannedWorkoutStepTarget>(ref reader, options);
            }
            global::Terra.SwimStrokePlannedWorkoutStepTarget? swimStrokePlannedWorkoutStepTarget = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepTargetsDiscriminatorType.SwimStrokePlannedWorkoutStepTarget)
            {
                swimStrokePlannedWorkoutStepTarget = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.SwimStrokePlannedWorkoutStepTarget>(ref reader, options);
            }

            var __value = new global::Terra.PlannedWorkoutStepTargets(
                discriminator?.Type,
                plannedWorkoutStepTarget,

                cadencePlannedWorkoutStepTarget,

                hRPlannedWorkoutStepTarget,

                powerPlannedWorkoutStepTarget,

                speedPlannedWorkoutStepTarget,

                pacePlannedWorkoutStepTarget,

                tSSPlannedWorkoutStepTarget,

                iFPlannedWorkoutStepTarget,

                repetitionPlannedWorkoutStepTarget,

                swimStrokePlannedWorkoutStepTarget
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.PlannedWorkoutStepTargets value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlannedWorkoutStepTarget, typeof(global::Terra.PlannedWorkoutStepTarget), options);
            }
            else if (value.IsCadencePlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CadencePlannedWorkoutStepTarget, typeof(global::Terra.CadencePlannedWorkoutStepTarget), options);
            }
            else if (value.IsHRPlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HRPlannedWorkoutStepTarget, typeof(global::Terra.HRPlannedWorkoutStepTarget), options);
            }
            else if (value.IsPowerPlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PowerPlannedWorkoutStepTarget, typeof(global::Terra.PowerPlannedWorkoutStepTarget), options);
            }
            else if (value.IsSpeedPlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeedPlannedWorkoutStepTarget, typeof(global::Terra.SpeedPlannedWorkoutStepTarget), options);
            }
            else if (value.IsPacePlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PacePlannedWorkoutStepTarget, typeof(global::Terra.PacePlannedWorkoutStepTarget), options);
            }
            else if (value.IsTSSPlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TSSPlannedWorkoutStepTarget, typeof(global::Terra.TSSPlannedWorkoutStepTarget), options);
            }
            else if (value.IsIFPlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IFPlannedWorkoutStepTarget, typeof(global::Terra.IFPlannedWorkoutStepTarget), options);
            }
            else if (value.IsRepetitionPlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepetitionPlannedWorkoutStepTarget, typeof(global::Terra.RepetitionPlannedWorkoutStepTarget), options);
            }
            else if (value.IsSwimStrokePlannedWorkoutStepTarget)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SwimStrokePlannedWorkoutStepTarget, typeof(global::Terra.SwimStrokePlannedWorkoutStepTarget), options);
            }
        }
    }
}