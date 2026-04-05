
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnoringData
    {
        /// <summary>
        /// The start time of the recording of snoring data, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T22:00:00.000000+02:00
        /// </summary>
        /// <example>1999-11-23T22:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// The end time of the recording of snoring data, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-24T08:00:00.000000+01:00
        /// </summary>
        /// <example>2022-11-24T08:00:00.000000+01:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Number of times over the sleep period when the user started snoring, as determined by the device.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_snoring_events")]
        public int? NumSnoringEvents { get; set; }

        /// <summary>
        /// List of snoring information data points sampled throughout the sleep session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Terra.SnoringSample>? Samples { get; set; }

        /// <summary>
        /// Total duration for which the user was snoring.<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_snoring_duration_seconds")]
        public double? TotalSnoringDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnoringData" /> class.
        /// </summary>
        /// <param name="startTime">
        /// The start time of the recording of snoring data, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T22:00:00.000000+02:00
        /// </param>
        /// <param name="endTime">
        /// The end time of the recording of snoring data, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-24T08:00:00.000000+01:00
        /// </param>
        /// <param name="numSnoringEvents">
        /// Number of times over the sleep period when the user started snoring, as determined by the device.<br/>
        /// Example: 12
        /// </param>
        /// <param name="samples">
        /// List of snoring information data points sampled throughout the sleep session.
        /// </param>
        /// <param name="totalSnoringDurationSeconds">
        /// Total duration for which the user was snoring.<br/>
        /// Example: 3600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnoringData(
            string? startTime,
            string? endTime,
            int? numSnoringEvents,
            global::System.Collections.Generic.IList<global::Terra.SnoringSample>? samples,
            double? totalSnoringDurationSeconds)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.NumSnoringEvents = numSnoringEvents;
            this.Samples = samples;
            this.TotalSnoringDurationSeconds = totalSnoringDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnoringData" /> class.
        /// </summary>
        public SnoringData()
        {
        }
    }
}