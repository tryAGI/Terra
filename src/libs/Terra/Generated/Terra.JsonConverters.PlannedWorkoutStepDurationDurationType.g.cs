#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class PlannedWorkoutStepDurationDurationTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.PlannedWorkoutStepDurationDurationType>
    {
        /// <inheritdoc />
        public override global::Terra.PlannedWorkoutStepDurationDurationType Read(
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
                        return global::Terra.PlannedWorkoutStepDurationDurationTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.PlannedWorkoutStepDurationDurationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.PlannedWorkoutStepDurationDurationType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.PlannedWorkoutStepDurationDurationType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.PlannedWorkoutStepDurationDurationTypeExtensions.ToValueString(value));
        }
    }
}
