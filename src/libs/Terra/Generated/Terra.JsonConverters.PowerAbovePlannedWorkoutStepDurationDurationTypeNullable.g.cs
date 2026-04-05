#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class PowerAbovePlannedWorkoutStepDurationDurationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.PowerAbovePlannedWorkoutStepDurationDurationType?>
    {
        /// <inheritdoc />
        public override global::Terra.PowerAbovePlannedWorkoutStepDurationDurationType? Read(
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
                        return global::Terra.PowerAbovePlannedWorkoutStepDurationDurationTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.PowerAbovePlannedWorkoutStepDurationDurationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.PowerAbovePlannedWorkoutStepDurationDurationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.PowerAbovePlannedWorkoutStepDurationDurationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Terra.PowerAbovePlannedWorkoutStepDurationDurationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
