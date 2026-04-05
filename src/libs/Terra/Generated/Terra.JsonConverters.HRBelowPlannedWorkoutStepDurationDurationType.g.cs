#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class HRBelowPlannedWorkoutStepDurationDurationTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.HRBelowPlannedWorkoutStepDurationDurationType>
    {
        /// <inheritdoc />
        public override global::Terra.HRBelowPlannedWorkoutStepDurationDurationType Read(
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
                        return global::Terra.HRBelowPlannedWorkoutStepDurationDurationTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.HRBelowPlannedWorkoutStepDurationDurationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.HRBelowPlannedWorkoutStepDurationDurationType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.HRBelowPlannedWorkoutStepDurationDurationType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.HRBelowPlannedWorkoutStepDurationDurationTypeExtensions.ToValueString(value));
        }
    }
}
