
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtherSleepDurations
    {
        /// <summary>
        /// Total duration of time spent in bed.<br/>
        /// Example: 28800
        /// </summary>
        /// <example>28800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_in_bed_seconds")]
        public double? DurationInBedSeconds { get; set; }

        /// <summary>
        /// Total duration during which the user's state (awake, asleep, REM, etc) was unmeasurable during the sleep session.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_unmeasurable_sleep_seconds")]
        public double? DurationUnmeasurableSleepSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherSleepDurations" /> class.
        /// </summary>
        /// <param name="durationInBedSeconds">
        /// Total duration of time spent in bed.<br/>
        /// Example: 28800
        /// </param>
        /// <param name="durationUnmeasurableSleepSeconds">
        /// Total duration during which the user's state (awake, asleep, REM, etc) was unmeasurable during the sleep session.<br/>
        /// Example: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtherSleepDurations(
            double? durationInBedSeconds,
            double? durationUnmeasurableSleepSeconds)
        {
            this.DurationInBedSeconds = durationInBedSeconds;
            this.DurationUnmeasurableSleepSeconds = durationUnmeasurableSleepSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherSleepDurations" /> class.
        /// </summary>
        public OtherSleepDurations()
        {
        }
    }
}