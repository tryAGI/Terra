#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class CardioPlannedWorkoutStepExerciseCategoryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.CardioPlannedWorkoutStepExerciseCategory>
    {
        /// <inheritdoc />
        public override global::Terra.CardioPlannedWorkoutStepExerciseCategory Read(
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
                        return global::Terra.CardioPlannedWorkoutStepExerciseCategoryExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.CardioPlannedWorkoutStepExerciseCategory)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.CardioPlannedWorkoutStepExerciseCategory);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.CardioPlannedWorkoutStepExerciseCategory value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.CardioPlannedWorkoutStepExerciseCategoryExtensions.ToValueString(value));
        }
    }
}
