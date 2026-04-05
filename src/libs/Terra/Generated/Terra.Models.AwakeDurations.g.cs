
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AwakeDurations
    {
        /// <summary>
        /// Total duration for which the user was awake during the sleep session.<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_awake_state_seconds")]
        public double? DurationAwakeStateSeconds { get; set; }

        /// <summary>
        /// Total duration for which the user was awake during the sleep session, when the interruption of their sleep was greater than 90 seconds.<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_long_interruption_seconds")]
        public double? DurationLongInterruptionSeconds { get; set; }

        /// <summary>
        /// Total duration for which the user was awake during the sleep session, when the interruption of their sleep was less than 90 seconds.<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_short_interruption_seconds")]
        public double? DurationShortInterruptionSeconds { get; set; }

        /// <summary>
        /// Number of times the user got out of bed during the sleep session.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_out_of_bed_events")]
        public int? NumOutOfBedEvents { get; set; }

        /// <summary>
        /// Number of times the user woke up during the sleep session.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_wakeup_events")]
        public int? NumWakeupEvents { get; set; }

        /// <summary>
        /// Sleep latency, defined as time between the moment the user lays in bed with the intention to sleep and the moment they actually fall asleep.<br/>
        /// Example: 900
        /// </summary>
        /// <example>900</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_latency_seconds")]
        public double? SleepLatencySeconds { get; set; }

        /// <summary>
        /// Wake up latency, defined as time between the moment the user wakes up and the moment they get out of bed.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("wake_up_latency_seconds")]
        public double? WakeUpLatencySeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AwakeDurations" /> class.
        /// </summary>
        /// <param name="durationAwakeStateSeconds">
        /// Total duration for which the user was awake during the sleep session.<br/>
        /// Example: 1200
        /// </param>
        /// <param name="durationLongInterruptionSeconds">
        /// Total duration for which the user was awake during the sleep session, when the interruption of their sleep was greater than 90 seconds.<br/>
        /// Example: 600
        /// </param>
        /// <param name="durationShortInterruptionSeconds">
        /// Total duration for which the user was awake during the sleep session, when the interruption of their sleep was less than 90 seconds.<br/>
        /// Example: 180
        /// </param>
        /// <param name="numOutOfBedEvents">
        /// Number of times the user got out of bed during the sleep session.<br/>
        /// Example: 1
        /// </param>
        /// <param name="numWakeupEvents">
        /// Number of times the user woke up during the sleep session.<br/>
        /// Example: 3
        /// </param>
        /// <param name="sleepLatencySeconds">
        /// Sleep latency, defined as time between the moment the user lays in bed with the intention to sleep and the moment they actually fall asleep.<br/>
        /// Example: 900
        /// </param>
        /// <param name="wakeUpLatencySeconds">
        /// Wake up latency, defined as time between the moment the user wakes up and the moment they get out of bed.<br/>
        /// Example: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AwakeDurations(
            double? durationAwakeStateSeconds,
            double? durationLongInterruptionSeconds,
            double? durationShortInterruptionSeconds,
            int? numOutOfBedEvents,
            int? numWakeupEvents,
            double? sleepLatencySeconds,
            double? wakeUpLatencySeconds)
        {
            this.DurationAwakeStateSeconds = durationAwakeStateSeconds;
            this.DurationLongInterruptionSeconds = durationLongInterruptionSeconds;
            this.DurationShortInterruptionSeconds = durationShortInterruptionSeconds;
            this.NumOutOfBedEvents = numOutOfBedEvents;
            this.NumWakeupEvents = numWakeupEvents;
            this.SleepLatencySeconds = sleepLatencySeconds;
            this.WakeUpLatencySeconds = wakeUpLatencySeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AwakeDurations" /> class.
        /// </summary>
        public AwakeDurations()
        {
        }
    }
}