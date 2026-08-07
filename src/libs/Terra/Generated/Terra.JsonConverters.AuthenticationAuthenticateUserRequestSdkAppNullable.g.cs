#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class AuthenticationAuthenticateUserRequestSdkAppNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.AuthenticationAuthenticateUserRequestSdkApp?>
    {
        /// <inheritdoc />
        public override global::Terra.AuthenticationAuthenticateUserRequestSdkApp? Read(
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
                        return global::Terra.AuthenticationAuthenticateUserRequestSdkAppExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.AuthenticationAuthenticateUserRequestSdkApp)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.AuthenticationAuthenticateUserRequestSdkApp?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.AuthenticationAuthenticateUserRequestSdkApp? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Terra.AuthenticationAuthenticateUserRequestSdkAppExtensions.ToValueString(value.Value));
            }
        }
    }
}
