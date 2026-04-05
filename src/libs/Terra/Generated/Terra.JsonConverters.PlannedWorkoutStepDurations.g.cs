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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PlannedWorkoutStepDurationsDiscriminator>(ref readerCopy, options);

            global::Terra.PlannedWorkoutStepDuration? plannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.PlannedWorkoutStepDuration)
            {
                plannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.TimePlannedWorkoutStepDuration? timePlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.TimePlannedWorkoutStepDuration)
            {
                timePlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.TimePlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.PowerAbovePlannedWorkoutStepDuration? powerAbovePlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.PowerAbovePlannedWorkoutStepDuration)
            {
                powerAbovePlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PowerAbovePlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.PowerBelowPlannedWorkoutStepDuration? powerBelowPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.PowerBelowPlannedWorkoutStepDuration)
            {
                powerBelowPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.PowerBelowPlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.FixedRestPlannedWorkoutStepDuration? fixedRestPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.FixedRestPlannedWorkoutStepDuration)
            {
                fixedRestPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.FixedRestPlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.CaloriesPlannedWorkoutStepDuration? caloriesPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.CaloriesPlannedWorkoutStepDuration)
            {
                caloriesPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.CaloriesPlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.HRAbovePlannedWorkoutStepDuration? hRAbovePlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.HRAbovePlannedWorkoutStepDuration)
            {
                hRAbovePlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.HRAbovePlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.HRBelowPlannedWorkoutStepDuration? hRBelowPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.HRBelowPlannedWorkoutStepDuration)
            {
                hRBelowPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.HRBelowPlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.RepsPlannedWorkoutStepDuration? repsPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.RepsPlannedWorkoutStepDuration)
            {
                repsPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.RepsPlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.DistancePlannedWorkoutStepDuration? distancePlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.DistancePlannedWorkoutStepDuration)
            {
                distancePlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.DistancePlannedWorkoutStepDuration>(ref reader, options);
            }
            global::Terra.StepsPlannedWorkoutStepDuration? stepsPlannedWorkoutStepDuration = default;
            if (discriminator?.Type == global::Terra.PlannedWorkoutStepDurationsDiscriminatorType.StepsPlannedWorkoutStepDuration)
            {
                stepsPlannedWorkoutStepDuration = global::System.Text.Json.JsonSerializer.Deserialize<global::Terra.StepsPlannedWorkoutStepDuration>(ref reader, options);
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

            if (value.IsPlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlannedWorkoutStepDuration, typeof(global::Terra.PlannedWorkoutStepDuration), options);
            }
            else if (value.IsTimePlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TimePlannedWorkoutStepDuration, typeof(global::Terra.TimePlannedWorkoutStepDuration), options);
            }
            else if (value.IsPowerAbovePlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PowerAbovePlannedWorkoutStepDuration, typeof(global::Terra.PowerAbovePlannedWorkoutStepDuration), options);
            }
            else if (value.IsPowerBelowPlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PowerBelowPlannedWorkoutStepDuration, typeof(global::Terra.PowerBelowPlannedWorkoutStepDuration), options);
            }
            else if (value.IsFixedRestPlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FixedRestPlannedWorkoutStepDuration, typeof(global::Terra.FixedRestPlannedWorkoutStepDuration), options);
            }
            else if (value.IsCaloriesPlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CaloriesPlannedWorkoutStepDuration, typeof(global::Terra.CaloriesPlannedWorkoutStepDuration), options);
            }
            else if (value.IsHRAbovePlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HRAbovePlannedWorkoutStepDuration, typeof(global::Terra.HRAbovePlannedWorkoutStepDuration), options);
            }
            else if (value.IsHRBelowPlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HRBelowPlannedWorkoutStepDuration, typeof(global::Terra.HRBelowPlannedWorkoutStepDuration), options);
            }
            else if (value.IsRepsPlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepsPlannedWorkoutStepDuration, typeof(global::Terra.RepsPlannedWorkoutStepDuration), options);
            }
            else if (value.IsDistancePlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DistancePlannedWorkoutStepDuration, typeof(global::Terra.DistancePlannedWorkoutStepDuration), options);
            }
            else if (value.IsStepsPlannedWorkoutStepDuration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepsPlannedWorkoutStepDuration, typeof(global::Terra.StepsPlannedWorkoutStepDuration), options);
            }
        }
    }
}