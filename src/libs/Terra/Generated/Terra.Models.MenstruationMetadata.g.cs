
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MenstruationMetadata
    {
        /// <summary>
        /// The end time of the associated day, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h after start_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-10-28T10:00:00.000000+01:00
        /// </summary>
        /// <example>2022-10-28T10:00:00.000000+01:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTime { get; set; }

        /// <summary>
        /// The start time of the associated day, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>1999-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// Indicates whether the timestamps in this payload are localized (LOCAL) or in UTC.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_localization")]
        public double? TimestampLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MenstruationMetadata" /> class.
        /// </summary>
        /// <param name="endTime">
        /// The end time of the associated day, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h after start_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-10-28T10:00:00.000000+01:00
        /// </param>
        /// <param name="startTime">
        /// The start time of the associated day, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="timestampLocalization">
        /// Indicates whether the timestamps in this payload are localized (LOCAL) or in UTC.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MenstruationMetadata(
            string endTime,
            string startTime,
            double? timestampLocalization)
        {
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.TimestampLocalization = timestampLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenstruationMetadata" /> class.
        /// </summary>
        public MenstruationMetadata()
        {
        }
    }
}