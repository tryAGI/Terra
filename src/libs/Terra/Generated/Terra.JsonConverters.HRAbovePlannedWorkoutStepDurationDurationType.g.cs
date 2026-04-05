#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class HRAbovePlannedWorkoutStepDurationDurationTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.HRAbovePlannedWorkoutStepDurationDurationType>
    {
        /// <inheritdoc />
        public override global::Terra.HRAbovePlannedWorkoutStepDurationDurationType Read(
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
                        return global::Terra.HRAbovePlannedWorkoutStepDurationDurationTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.HRAbovePlannedWorkoutStepDurationDurationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.HRAbovePlannedWorkoutStepDurationDurationType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.HRAbovePlannedWorkoutStepDurationDurationType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.HRAbovePlannedWorkoutStepDurationDurationTypeExtensions.ToValueString(value));
        }
    }
}
