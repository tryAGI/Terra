
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActiveDurationsData
    {
        /// <summary>
        /// Array of detailed samples of the intensity the user was in at various points during the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_levels_samples")]
        public global::System.Collections.Generic.IList<global::Terra.ActivityLevelSample>? ActivityLevelsSamples { get; set; }

        /// <summary>
        /// Total number of seconds spent in an active state during the workout.<br/>
        /// Example: 1800
        /// </summary>
        /// <example>1800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_seconds")]
        public double? ActivitySeconds { get; set; }

        /// <summary>
        /// Total number of seconds spent in an inactive state during the workout.<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivity_seconds")]
        public double? InactivitySeconds { get; set; }

        /// <summary>
        /// Total number of seconds spent in a low intensity state during the workout.<br/>
        /// Example: 900
        /// </summary>
        /// <example>900</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_intensity_seconds")]
        public double? LowIntensitySeconds { get; set; }

        /// <summary>
        /// Total number of seconds spent in a moderate intensity state during the workout.<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderate_intensity_seconds")]
        public double? ModerateIntensitySeconds { get; set; }

        /// <summary>
        /// Maximum number of continuous periods spent in an inactive state during the workout.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_continuous_inactive_periods")]
        public int? NumContinuousInactivePeriods { get; set; }

        /// <summary>
        /// Total number of seconds spent resting during the workout.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rest_seconds")]
        public double? RestSeconds { get; set; }

        /// <summary>
        /// Total number of seconds spent in a state of vigorous intensity during the workout.<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vigorous_intensity_seconds")]
        public double? VigorousIntensitySeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standing_hours_count")]
        public double? StandingHoursCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standing_seconds")]
        public double? StandingSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDurationsData" /> class.
        /// </summary>
        /// <param name="activityLevelsSamples">
        /// Array of detailed samples of the intensity the user was in at various points during the workout.
        /// </param>
        /// <param name="activitySeconds">
        /// Total number of seconds spent in an active state during the workout.<br/>
        /// Example: 1800
        /// </param>
        /// <param name="inactivitySeconds">
        /// Total number of seconds spent in an inactive state during the workout.<br/>
        /// Example: 600
        /// </param>
        /// <param name="lowIntensitySeconds">
        /// Total number of seconds spent in a low intensity state during the workout.<br/>
        /// Example: 900
        /// </param>
        /// <param name="moderateIntensitySeconds">
        /// Total number of seconds spent in a moderate intensity state during the workout.<br/>
        /// Example: 600
        /// </param>
        /// <param name="numContinuousInactivePeriods">
        /// Maximum number of continuous periods spent in an inactive state during the workout.<br/>
        /// Example: 3
        /// </param>
        /// <param name="restSeconds">
        /// Total number of seconds spent resting during the workout.<br/>
        /// Example: 120
        /// </param>
        /// <param name="vigorousIntensitySeconds">
        /// Total number of seconds spent in a state of vigorous intensity during the workout.<br/>
        /// Example: 300
        /// </param>
        /// <param name="standingHoursCount"></param>
        /// <param name="standingSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActiveDurationsData(
            global::System.Collections.Generic.IList<global::Terra.ActivityLevelSample>? activityLevelsSamples,
            double? activitySeconds,
            double? inactivitySeconds,
            double? lowIntensitySeconds,
            double? moderateIntensitySeconds,
            int? numContinuousInactivePeriods,
            double? restSeconds,
            double? vigorousIntensitySeconds,
            double? standingHoursCount,
            double? standingSeconds)
        {
            this.ActivityLevelsSamples = activityLevelsSamples;
            this.ActivitySeconds = activitySeconds;
            this.InactivitySeconds = inactivitySeconds;
            this.LowIntensitySeconds = lowIntensitySeconds;
            this.ModerateIntensitySeconds = moderateIntensitySeconds;
            this.NumContinuousInactivePeriods = numContinuousInactivePeriods;
            this.RestSeconds = restSeconds;
            this.VigorousIntensitySeconds = vigorousIntensitySeconds;
            this.StandingHoursCount = standingHoursCount;
            this.StandingSeconds = standingSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDurationsData" /> class.
        /// </summary>
        public ActiveDurationsData()
        {
        }
    }
}