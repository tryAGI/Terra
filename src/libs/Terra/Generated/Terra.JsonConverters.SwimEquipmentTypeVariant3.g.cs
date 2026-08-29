#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class SwimEquipmentTypeVariant3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.SwimEquipmentTypeVariant3>
    {
        /// <inheritdoc />
        public override global::Terra.SwimEquipmentTypeVariant3 Read(
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
                        return global::Terra.SwimEquipmentTypeVariant3Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.SwimEquipmentTypeVariant3)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.SwimEquipmentTypeVariant3);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.SwimEquipmentTypeVariant3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.SwimEquipmentTypeVariant3Extensions.ToValueString(value));
        }
    }
}
