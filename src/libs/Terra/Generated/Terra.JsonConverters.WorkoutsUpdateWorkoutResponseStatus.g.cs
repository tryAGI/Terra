#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkoutsUpdateWorkoutResponseStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.WorkoutsUpdateWorkoutResponseStatus>
    {
        /// <inheritdoc />
        public override global::Terra.WorkoutsUpdateWorkoutResponseStatus Read(
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
                        return global::Terra.WorkoutsUpdateWorkoutResponseStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.WorkoutsUpdateWorkoutResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.WorkoutsUpdateWorkoutResponseStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.WorkoutsUpdateWorkoutResponseStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.WorkoutsUpdateWorkoutResponseStatusExtensions.ToValueString(value));
        }
    }
}
