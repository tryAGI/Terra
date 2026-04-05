#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class AuthenticationAuthenticateUserResponseStatus2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.AuthenticationAuthenticateUserResponseStatus2?>
    {
        /// <inheritdoc />
        public override global::Terra.AuthenticationAuthenticateUserResponseStatus2? Read(
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
                        return global::Terra.AuthenticationAuthenticateUserResponseStatus2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.AuthenticationAuthenticateUserResponseStatus2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.AuthenticationAuthenticateUserResponseStatus2?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.AuthenticationAuthenticateUserResponseStatus2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Terra.AuthenticationAuthenticateUserResponseStatus2Extensions.ToValueString(value.Value));
            }
        }
    }
}
