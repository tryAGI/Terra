#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class YogaPlannedWorkoutStepTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.YogaPlannedWorkoutStepType>
    {
        /// <inheritdoc />
        public override global::Terra.YogaPlannedWorkoutStepType Read(
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
                        return global::Terra.YogaPlannedWorkoutStepTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.YogaPlannedWorkoutStepType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.YogaPlannedWorkoutStepType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.YogaPlannedWorkoutStepType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.YogaPlannedWorkoutStepTypeExtensions.ToValueString(value));
        }
    }
}
