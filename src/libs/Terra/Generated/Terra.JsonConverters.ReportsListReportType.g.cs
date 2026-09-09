#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReportsListReportTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.ReportsListReportType>
    {
        /// <inheritdoc />
        public override global::Terra.ReportsListReportType Read(
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
                        return global::Terra.ReportsListReportTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.ReportsListReportType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.ReportsListReportType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.ReportsListReportType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.ReportsListReportTypeExtensions.ToValueString(value));
        }
    }
}
