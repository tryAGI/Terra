#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class AthleteFetchResponseStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.AthleteFetchResponseStatus>
    {
        /// <inheritdoc />
        public override global::Terra.AthleteFetchResponseStatus Read(
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
                        return global::Terra.AthleteFetchResponseStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.AthleteFetchResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.AthleteFetchResponseStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.AthleteFetchResponseStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.AthleteFetchResponseStatusExtensions.ToValueString(value));
        }
    }
}
