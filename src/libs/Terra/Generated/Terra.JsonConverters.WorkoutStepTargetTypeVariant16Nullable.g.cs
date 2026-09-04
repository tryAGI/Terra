#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkoutStepTargetTypeVariant16NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.WorkoutStepTargetTypeVariant16?>
    {
        /// <inheritdoc />
        public override global::Terra.WorkoutStepTargetTypeVariant16? Read(
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
                        return global::Terra.WorkoutStepTargetTypeVariant16Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.WorkoutStepTargetTypeVariant16)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.WorkoutStepTargetTypeVariant16?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.WorkoutStepTargetTypeVariant16? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Terra.WorkoutStepTargetTypeVariant16Extensions.ToValueString(value.Value));
            }
        }
    }
}
