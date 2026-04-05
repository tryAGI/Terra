
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeedSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Speed of the user at a given instant in time, in meters per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_meters_per_second")]
        public double? SpeedMetersPerSecond { get; set; }

        /// <summary>
        /// Time elapsed since the start of the workout, subtracting time during which the recording was paused
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timer_duration_seconds")]
        public double? TimerDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="speedMetersPerSecond">
        /// Speed of the user at a given instant in time, in meters per second
        /// </param>
        /// <param name="timerDurationSeconds">
        /// Time elapsed since the start of the workout, subtracting time during which the recording was paused
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeedSample(
            string? timestamp,
            double? speedMetersPerSecond,
            double? timerDurationSeconds)
        {
            this.Timestamp = timestamp;
            this.SpeedMetersPerSecond = speedMetersPerSecond;
            this.TimerDurationSeconds = timerDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedSample" /> class.
        /// </summary>
        public SpeedSample()
        {
        }
    }
}