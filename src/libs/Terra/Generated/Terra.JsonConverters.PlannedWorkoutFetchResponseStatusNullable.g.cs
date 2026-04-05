#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class PlannedWorkoutFetchResponseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.PlannedWorkoutFetchResponseStatus?>
    {
        /// <inheritdoc />
        public override global::Terra.PlannedWorkoutFetchResponseStatus? Read(
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
                        return global::Terra.PlannedWorkoutFetchResponseStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.PlannedWorkoutFetchResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.PlannedWorkoutFetchResponseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.PlannedWorkoutFetchResponseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Terra.PlannedWorkoutFetchResponseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
