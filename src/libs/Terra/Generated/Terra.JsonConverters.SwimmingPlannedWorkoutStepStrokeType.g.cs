#nullable enable

namespace Terra.JsonConverters
{
    /// <inheritdoc />
    public sealed class SwimmingPlannedWorkoutStepStrokeTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Terra.SwimmingPlannedWorkoutStepStrokeType>
    {
        /// <inheritdoc />
        public override global::Terra.SwimmingPlannedWorkoutStepStrokeType Read(
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
                        return global::Terra.SwimmingPlannedWorkoutStepStrokeTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Terra.SwimmingPlannedWorkoutStepStrokeType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Terra.SwimmingPlannedWorkoutStepStrokeType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Terra.SwimmingPlannedWorkoutStepStrokeType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Terra.SwimmingPlannedWorkoutStepStrokeTypeExtensions.ToValueString(value));
        }
    }
}
