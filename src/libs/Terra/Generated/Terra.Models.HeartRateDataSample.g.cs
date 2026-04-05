
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartRateDataSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// User's heart rate in bpm<br/>
        /// Example: 142
        /// </summary>
        /// <example>142</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public double? Bpm { get; set; }

        /// <summary>
        /// Time elapsed since the start of the workout, subtracting time during which the recording was paused<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timer_duration_seconds")]
        public double? TimerDurationSeconds { get; set; }

        /// <summary>
        /// Represents the context in which heart rate was measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public double? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateDataSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="bpm">
        /// User's heart rate in bpm<br/>
        /// Example: 142
        /// </param>
        /// <param name="timerDurationSeconds">
        /// Time elapsed since the start of the workout, subtracting time during which the recording was paused<br/>
        /// Example: 600
        /// </param>
        /// <param name="context">
        /// Represents the context in which heart rate was measured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartRateDataSample(
            string? timestamp,
            double? bpm,
            double? timerDurationSeconds,
            double? context)
        {
            this.Timestamp = timestamp;
            this.Bpm = bpm;
            this.TimerDurationSeconds = timerDurationSeconds;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateDataSample" /> class.
        /// </summary>
        public HeartRateDataSample()
        {
        }
    }
}