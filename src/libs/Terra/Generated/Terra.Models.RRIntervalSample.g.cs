
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RRIntervalSample
    {
        /// <summary>
        /// User's RR Interval for a specific heart beat in milliseconds.<br/>
        /// Example: 850
        /// </summary>
        /// <example>850</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rr_interval_ms")]
        public double? RrIntervalMs { get; set; }

        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// The heart beat value at that specific instance.<br/>
        /// Example: 72
        /// </summary>
        /// <example>72</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_bpm")]
        public double? HrBpm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RRIntervalSample" /> class.
        /// </summary>
        /// <param name="rrIntervalMs">
        /// User's RR Interval for a specific heart beat in milliseconds.<br/>
        /// Example: 850
        /// </param>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="hrBpm">
        /// The heart beat value at that specific instance.<br/>
        /// Example: 72
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RRIntervalSample(
            double? rrIntervalMs,
            string? timestamp,
            double? hrBpm)
        {
            this.RrIntervalMs = rrIntervalMs;
            this.Timestamp = timestamp;
            this.HrBpm = hrBpm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RRIntervalSample" /> class.
        /// </summary>
        public RRIntervalSample()
        {
        }
    }
}