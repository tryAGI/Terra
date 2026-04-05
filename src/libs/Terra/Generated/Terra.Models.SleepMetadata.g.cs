
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepMetadata
    {
        /// <summary>
        /// The end time of the associated sleep session, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-24T08:00:00.000000+01:00
        /// </summary>
        /// <example>2022-11-24T08:00:00.000000+01:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTime { get; set; }

        /// <summary>
        /// Flag indicating whether the sleep session was a nap, or the user's main sleep session for the day.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_nap")]
        public bool? IsNap { get; set; }

        /// <summary>
        /// The start time of the associated sleep session, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T22:00:00.000000+02:00
        /// </summary>
        /// <example>1999-11-23T22:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// A unique identifier for the sleep session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_id")]
        public string? SummaryId { get; set; }

        /// <summary>
        /// Indicates whether the timestamps in this payload are localized (LOCAL) or in UTC.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_localization")]
        public double? TimestampLocalization { get; set; }

        /// <summary>
        /// The upload type for the associated workout, providing information on whether this was an automatic workout or user-entered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UploadType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepMetadata" /> class.
        /// </summary>
        /// <param name="endTime">
        /// The end time of the associated sleep session, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-24T08:00:00.000000+01:00
        /// </param>
        /// <param name="startTime">
        /// The start time of the associated sleep session, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T22:00:00.000000+02:00
        /// </param>
        /// <param name="uploadType">
        /// The upload type for the associated workout, providing information on whether this was an automatic workout or user-entered
        /// </param>
        /// <param name="isNap">
        /// Flag indicating whether the sleep session was a nap, or the user's main sleep session for the day.<br/>
        /// Example: false
        /// </param>
        /// <param name="summaryId">
        /// A unique identifier for the sleep session.
        /// </param>
        /// <param name="timestampLocalization">
        /// Indicates whether the timestamps in this payload are localized (LOCAL) or in UTC.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepMetadata(
            string endTime,
            string startTime,
            double uploadType,
            bool? isNap,
            string? summaryId,
            double? timestampLocalization)
        {
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
            this.IsNap = isNap;
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.SummaryId = summaryId;
            this.TimestampLocalization = timestampLocalization;
            this.UploadType = uploadType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepMetadata" /> class.
        /// </summary>
        public SleepMetadata()
        {
        }
    }
}