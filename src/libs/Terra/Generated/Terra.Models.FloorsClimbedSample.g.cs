
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FloorsClimbedSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Cumulative number of elevation gain measured in floors climbed up to associated timestamp, since the start of the payload<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("floors_climbed")]
        public int? FloorsClimbed { get; set; }

        /// <summary>
        /// Time elapsed since the start of the workout, subtracting time during which the recording was paused<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timer_duration_seconds")]
        public double? TimerDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorsClimbedSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="floorsClimbed">
        /// Cumulative number of elevation gain measured in floors climbed up to associated timestamp, since the start of the payload<br/>
        /// Example: 5
        /// </param>
        /// <param name="timerDurationSeconds">
        /// Time elapsed since the start of the workout, subtracting time during which the recording was paused<br/>
        /// Example: 600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FloorsClimbedSample(
            string? timestamp,
            int? floorsClimbed,
            double? timerDurationSeconds)
        {
            this.Timestamp = timestamp;
            this.FloorsClimbed = floorsClimbed;
            this.TimerDurationSeconds = timerDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorsClimbedSample" /> class.
        /// </summary>
        public FloorsClimbedSample()
        {
        }
    }
}