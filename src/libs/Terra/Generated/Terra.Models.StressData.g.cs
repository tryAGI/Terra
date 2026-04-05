
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StressData
    {
        /// <summary>
        /// Average stress level for the day.<br/>
        /// Example: 45.5
        /// </summary>
        /// <example>45.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_stress_level")]
        public double? AvgStressLevel { get; set; }

        /// <summary>
        /// Total number of seconds spent in a stressed state while active during the day.<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_stress_duration_seconds")]
        public double? ActivityStressDurationSeconds { get; set; }

        /// <summary>
        /// Total number of seconds spent in a state of low stress during the day.<br/>
        /// Example: 28800
        /// </summary>
        /// <example>28800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_stress_duration_seconds")]
        public double? LowStressDurationSeconds { get; set; }

        /// <summary>
        /// Maximum stress level recorded during the day.<br/>
        /// Example: 85
        /// </summary>
        /// <example>85</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_stress_level")]
        public double? MaxStressLevel { get; set; }

        /// <summary>
        /// Total number of seconds spent in a state of medium stress during the day.<br/>
        /// Example: 7200
        /// </summary>
        /// <example>7200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium_stress_duration_seconds")]
        public double? MediumStressDurationSeconds { get; set; }

        /// <summary>
        /// Array of stress level data points sampled throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Terra.StressSample>? Samples { get; set; }

        /// <summary>
        /// Total number of seconds spent in a stressed state while at rest during the day.<br/>
        /// Example: 1800
        /// </summary>
        /// <example>1800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rest_stress_duration_seconds")]
        public double? RestStressDurationSeconds { get; set; }

        /// <summary>
        /// Total number of seconds spent in a state of high stress during the day.<br/>
        /// Example: 900
        /// </summary>
        /// <example>900</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_stress_duration_seconds")]
        public double? HighStressDurationSeconds { get; set; }

        /// <summary>
        /// Total number of seconds spent in any stressed state during the day.<br/>
        /// Example: 5400
        /// </summary>
        /// <example>5400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress_duration_seconds")]
        public double? StressDurationSeconds { get; set; }

        /// <summary>
        /// Represents stress level ranges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress_rating")]
        public double? StressRating { get; set; }

        /// <summary>
        /// Array of Body Battery data points sampled throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_battery_samples")]
        public global::System.Collections.Generic.IList<global::Terra.BodyBatterySample>? BodyBatterySamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StressData" /> class.
        /// </summary>
        /// <param name="avgStressLevel">
        /// Average stress level for the day.<br/>
        /// Example: 45.5
        /// </param>
        /// <param name="activityStressDurationSeconds">
        /// Total number of seconds spent in a stressed state while active during the day.<br/>
        /// Example: 3600
        /// </param>
        /// <param name="lowStressDurationSeconds">
        /// Total number of seconds spent in a state of low stress during the day.<br/>
        /// Example: 28800
        /// </param>
        /// <param name="maxStressLevel">
        /// Maximum stress level recorded during the day.<br/>
        /// Example: 85
        /// </param>
        /// <param name="mediumStressDurationSeconds">
        /// Total number of seconds spent in a state of medium stress during the day.<br/>
        /// Example: 7200
        /// </param>
        /// <param name="samples">
        /// Array of stress level data points sampled throughout the day.
        /// </param>
        /// <param name="restStressDurationSeconds">
        /// Total number of seconds spent in a stressed state while at rest during the day.<br/>
        /// Example: 1800
        /// </param>
        /// <param name="highStressDurationSeconds">
        /// Total number of seconds spent in a state of high stress during the day.<br/>
        /// Example: 900
        /// </param>
        /// <param name="stressDurationSeconds">
        /// Total number of seconds spent in any stressed state during the day.<br/>
        /// Example: 5400
        /// </param>
        /// <param name="stressRating">
        /// Represents stress level ranges.
        /// </param>
        /// <param name="bodyBatterySamples">
        /// Array of Body Battery data points sampled throughout the day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StressData(
            double? avgStressLevel,
            double? activityStressDurationSeconds,
            double? lowStressDurationSeconds,
            double? maxStressLevel,
            double? mediumStressDurationSeconds,
            global::System.Collections.Generic.IList<global::Terra.StressSample>? samples,
            double? restStressDurationSeconds,
            double? highStressDurationSeconds,
            double? stressDurationSeconds,
            double? stressRating,
            global::System.Collections.Generic.IList<global::Terra.BodyBatterySample>? bodyBatterySamples)
        {
            this.AvgStressLevel = avgStressLevel;
            this.ActivityStressDurationSeconds = activityStressDurationSeconds;
            this.LowStressDurationSeconds = lowStressDurationSeconds;
            this.MaxStressLevel = maxStressLevel;
            this.MediumStressDurationSeconds = mediumStressDurationSeconds;
            this.Samples = samples;
            this.RestStressDurationSeconds = restStressDurationSeconds;
            this.HighStressDurationSeconds = highStressDurationSeconds;
            this.StressDurationSeconds = stressDurationSeconds;
            this.StressRating = stressRating;
            this.BodyBatterySamples = bodyBatterySamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StressData" /> class.
        /// </summary>
        public StressData()
        {
        }
    }
}