#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkoutStepTargetTypeVariant10JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.WorkoutStepTargetTypeVariant10>
    {
        /// <inheritdoc />
        public override global::Terra.WorkoutStepTargetTypeVariant10 Read(
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
                        return global::Terra.WorkoutStepTargetTypeVariant10Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.WorkoutStepTargetTypeVariant10)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.WorkoutStepTargetTypeVariant10);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.WorkoutStepTargetTypeVariant10 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.WorkoutStepTargetTypeVariant10Extensions.ToValueString(value));
        }
    }
}
