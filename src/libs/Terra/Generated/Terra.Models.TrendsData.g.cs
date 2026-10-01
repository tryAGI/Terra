
#nullable enable

namespace Terra
{
    /// <summary>
    /// Personal baselines and trends for the user, as of the record. Present on sleep and daily payloads for customers with the trends product enabled; null otherwise.
    /// </summary>
    public sealed partial class TrendsData
    {
        /// <summary>
        /// Length of each window in days.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowDays { get; set; }

        /// <summary>
        /// Inclusive ISO date (yyyy-mm-dd) the trailing window ends on: the last completed local day before the record's own.<br/>
        /// Example: 2026-09-15
        /// </summary>
        /// <example>2026-09-15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WindowEnd { get; set; }

        /// <summary>
        /// Resting heart rate trend, in bpm. Source: daily summaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resting_heart_rate")]
        public global::Terra.MetricTrend? RestingHeartRate { get; set; }

        /// <summary>
        /// Heart-rate variability (RMSSD) trend, in ms. Source: sleep sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv_rmssd")]
        public global::Terra.MetricTrend? HrvRmssd { get; set; }

        /// <summary>
        /// Heart-rate variability (SDNN) trend, in ms. Source: sleep sessions. Apple Health reports SDNN rather than RMSSD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv_sdnn")]
        public global::Terra.MetricTrend? HrvSdnn { get; set; }

        /// <summary>
        /// Time asleep per session trend, in seconds (matches sleep_durations_data.asleep_time). Source: sleep sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_duration")]
        public global::Terra.MetricTrend? SleepDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendsData" /> class.
        /// </summary>
        /// <param name="windowDays">
        /// Length of each window in days.<br/>
        /// Example: 30
        /// </param>
        /// <param name="windowEnd">
        /// Inclusive ISO date (yyyy-mm-dd) the trailing window ends on: the last completed local day before the record's own.<br/>
        /// Example: 2026-09-15
        /// </param>
        /// <param name="restingHeartRate">
        /// Resting heart rate trend, in bpm. Source: daily summaries.
        /// </param>
        /// <param name="hrvRmssd">
        /// Heart-rate variability (RMSSD) trend, in ms. Source: sleep sessions.
        /// </param>
        /// <param name="hrvSdnn">
        /// Heart-rate variability (SDNN) trend, in ms. Source: sleep sessions. Apple Health reports SDNN rather than RMSSD.
        /// </param>
        /// <param name="sleepDuration">
        /// Time asleep per session trend, in seconds (matches sleep_durations_data.asleep_time). Source: sleep sessions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrendsData(
            int windowDays,
            string windowEnd,
            global::Terra.MetricTrend? restingHeartRate,
            global::Terra.MetricTrend? hrvRmssd,
            global::Terra.MetricTrend? hrvSdnn,
            global::Terra.MetricTrend? sleepDuration)
        {
            this.WindowDays = windowDays;
            this.WindowEnd = windowEnd ?? throw new global::System.ArgumentNullException(nameof(windowEnd));
            this.RestingHeartRate = restingHeartRate;
            this.HrvRmssd = hrvRmssd;
            this.HrvSdnn = hrvSdnn;
            this.SleepDuration = sleepDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendsData" /> class.
        /// </summary>
        public TrendsData()
        {
        }

    }
}