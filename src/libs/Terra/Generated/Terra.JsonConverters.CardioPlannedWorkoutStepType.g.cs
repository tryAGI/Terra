#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class CardioPlannedWorkoutStepTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.CardioPlannedWorkoutStepType>
    {
        /// <inheritdoc />
        public override global::Terra.CardioPlannedWorkoutStepType Read(
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
                        return global::Terra.CardioPlannedWorkoutStepTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.CardioPlannedWorkoutStepType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.CardioPlannedWorkoutStepType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.CardioPlannedWorkoutStepType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.CardioPlannedWorkoutStepTypeExtensions.ToValueString(value));
        }
    }
}
