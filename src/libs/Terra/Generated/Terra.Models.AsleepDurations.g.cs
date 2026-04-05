
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsleepDurations
    {
        /// <summary>
        /// Total duration for which the user was asleep, in any state.<br/>
        /// Example: 25200
        /// </summary>
        /// <example>25200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_asleep_state_seconds")]
        public double? DurationAsleepStateSeconds { get; set; }

        /// <summary>
        /// Total duration for which the user was in a state of deep sleep.<br/>
        /// Example: 5400
        /// </summary>
        /// <example>5400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_deep_sleep_state_seconds")]
        public double? DurationDeepSleepStateSeconds { get; set; }

        /// <summary>
        /// Total duration for which the user was in a state of light sleep.<br/>
        /// Example: 14400
        /// </summary>
        /// <example>14400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_light_sleep_state_seconds")]
        public double? DurationLightSleepStateSeconds { get; set; }

        /// <summary>
        /// Total duration for which the user was in a state of REM sleep.<br/>
        /// Example: 5400
        /// </summary>
        /// <example>5400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_REM_sleep_state_seconds")]
        public double? DurationRemSleepStateSeconds { get; set; }

        /// <summary>
        /// Number of periods of REM sleep captured during the sleep session.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_REM_events")]
        public int? NumRemEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsleepDurations" /> class.
        /// </summary>
        /// <param name="durationAsleepStateSeconds">
        /// Total duration for which the user was asleep, in any state.<br/>
        /// Example: 25200
        /// </param>
        /// <param name="durationDeepSleepStateSeconds">
        /// Total duration for which the user was in a state of deep sleep.<br/>
        /// Example: 5400
        /// </param>
        /// <param name="durationLightSleepStateSeconds">
        /// Total duration for which the user was in a state of light sleep.<br/>
        /// Example: 14400
        /// </param>
        /// <param name="durationRemSleepStateSeconds">
        /// Total duration for which the user was in a state of REM sleep.<br/>
        /// Example: 5400
        /// </param>
        /// <param name="numRemEvents">
        /// Number of periods of REM sleep captured during the sleep session.<br/>
        /// Example: 4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsleepDurations(
            double? durationAsleepStateSeconds,
            double? durationDeepSleepStateSeconds,
            double? durationLightSleepStateSeconds,
            double? durationRemSleepStateSeconds,
            int? numRemEvents)
        {
            this.DurationAsleepStateSeconds = durationAsleepStateSeconds;
            this.DurationDeepSleepStateSeconds = durationDeepSleepStateSeconds;
            this.DurationLightSleepStateSeconds = durationLightSleepStateSeconds;
            this.DurationRemSleepStateSeconds = durationRemSleepStateSeconds;
            this.NumRemEvents = numRemEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsleepDurations" /> class.
        /// </summary>
        public AsleepDurations()
        {
        }
    }
}