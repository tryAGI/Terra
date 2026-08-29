
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HealthObservationMetadata
    {
        /// <summary>
        /// When the observation occurred (or began), in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-10-28T10:00:00.000000+01:00
        /// </summary>
        /// <example>2022-10-28T10:00:00.000000+01:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// When the observation ended, in ISO8601 format, for interval observations. Absent for point-in-time observations.<br/>
        /// Example: 2022-10-28T10:05:00.000000+01:00
        /// </summary>
        /// <example>2022-10-28T10:05:00.000000+01:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Stable identifier for the source record (e.g. the HealthKit sample UUID). Re-deliveries and amendments reuse the same summary_id — treat it as the upsert key.<br/>
        /// Example: 7C3A5D9E-1F42-4B5A-9C1D-2E8F0A6B4C3D
        /// </summary>
        /// <example>7C3A5D9E-1F42-4B5A-9C1D-2E8F0A6B4C3D</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SummaryId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_localization")]
        public double? TimestampLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthObservationMetadata" /> class.
        /// </summary>
        /// <param name="startTime">
        /// When the observation occurred (or began), in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-10-28T10:00:00.000000+01:00
        /// </param>
        /// <param name="summaryId">
        /// Stable identifier for the source record (e.g. the HealthKit sample UUID). Re-deliveries and amendments reuse the same summary_id — treat it as the upsert key.<br/>
        /// Example: 7C3A5D9E-1F42-4B5A-9C1D-2E8F0A6B4C3D
        /// </param>
        /// <param name="endTime">
        /// When the observation ended, in ISO8601 format, for interval observations. Absent for point-in-time observations.<br/>
        /// Example: 2022-10-28T10:05:00.000000+01:00
        /// </param>
        /// <param name="timestampLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HealthObservationMetadata(
            string startTime,
            string summaryId,
            string? endTime,
            double? timestampLocalization)
        {
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.EndTime = endTime;
            this.SummaryId = summaryId ?? throw new global::System.ArgumentNullException(nameof(summaryId));
            this.TimestampLocalization = timestampLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthObservationMetadata" /> class.
        /// </summary>
        public HealthObservationMetadata()
        {
        }

    }
}