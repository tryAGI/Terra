#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class CompletionConditionTypeVariant3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.CompletionConditionTypeVariant3>
    {
        /// <inheritdoc />
        public override global::Terra.CompletionConditionTypeVariant3 Read(
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
                        return global::Terra.CompletionConditionTypeVariant3Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.CompletionConditionTypeVariant3)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.CompletionConditionTypeVariant3);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.CompletionConditionTypeVariant3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.CompletionConditionTypeVariant3Extensions.ToValueString(value));
        }
    }
}
