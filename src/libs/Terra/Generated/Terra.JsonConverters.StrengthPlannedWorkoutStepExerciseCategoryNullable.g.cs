#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class StrengthPlannedWorkoutStepExerciseCategoryNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.StrengthPlannedWorkoutStepExerciseCategory?>
    {
        /// <inheritdoc />
        public override global::Terra.StrengthPlannedWorkoutStepExerciseCategory? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Terra.StrengthPlannedWorkoutStepExerciseCategoryExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.StrengthPlannedWorkoutStepExerciseCategory)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.StrengthPlannedWorkoutStepExerciseCategory?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.StrengthPlannedWorkoutStepExerciseCategory? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Terra.StrengthPlannedWorkoutStepExerciseCategoryExtensions.ToValueString(value.Value));
            }
        }
    }
}
