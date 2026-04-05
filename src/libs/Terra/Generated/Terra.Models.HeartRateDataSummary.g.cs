
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartRateDataSummary
    {
        /// <summary>
        /// Average HeartRate of the user during the workout.<br/>
        /// Example: 145
        /// </summary>
        /// <example>145</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_hr_bpm")]
        public double? AvgHrBpm { get; set; }

        /// <summary>
        /// Average HeartRate Variability of the user during the workout, computed using RMSSD.<br/>
        /// Example: 35.2
        /// </summary>
        /// <example>35.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_hrv_rmssd")]
        public double? AvgHrvRmssd { get; set; }

        /// <summary>
        /// Average HeartRate Variability of the user during the workout, computed using SDNN.<br/>
        /// Example: 45.5
        /// </summary>
        /// <example>45.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_hrv_sdnn")]
        public double? AvgHrvSdnn { get; set; }

        /// <summary>
        /// Array of time spent in various HR zones throughout the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_zone_data")]
        public global::System.Collections.Generic.IList<global::Terra.HeartRateZoneData>? HrZoneData { get; set; }

        /// <summary>
        /// Maximum HeartRate of the user during the workout.<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_hr_bpm")]
        public double? MaxHrBpm { get; set; }

        /// <summary>
        /// Minimum HeartRate of the user during the workout.<br/>
        /// Example: 85
        /// </summary>
        /// <example>85</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_hr_bpm")]
        public double? MinHrBpm { get; set; }

        /// <summary>
        /// Resting HeartRate of the user, as determined by the fitness data provider.<br/>
        /// Example: 65
        /// </summary>
        /// <example>65</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resting_hr_bpm")]
        public double? RestingHrBpm { get; set; }

        /// <summary>
        /// User's maximum HeartRate based on their age, and other factors as determined by the fitness data provider.<br/>
        /// Example: 190
        /// </summary>
        /// <example>190</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_max_hr_bpm")]
        public double? UserMaxHrBpm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateDataSummary" /> class.
        /// </summary>
        /// <param name="avgHrBpm">
        /// Average HeartRate of the user during the workout.<br/>
        /// Example: 145
        /// </param>
        /// <param name="avgHrvRmssd">
        /// Average HeartRate Variability of the user during the workout, computed using RMSSD.<br/>
        /// Example: 35.2
        /// </param>
        /// <param name="avgHrvSdnn">
        /// Average HeartRate Variability of the user during the workout, computed using SDNN.<br/>
        /// Example: 45.5
        /// </param>
        /// <param name="hrZoneData">
        /// Array of time spent in various HR zones throughout the workout.
        /// </param>
        /// <param name="maxHrBpm">
        /// Maximum HeartRate of the user during the workout.<br/>
        /// Example: 180
        /// </param>
        /// <param name="minHrBpm">
        /// Minimum HeartRate of the user during the workout.<br/>
        /// Example: 85
        /// </param>
        /// <param name="restingHrBpm">
        /// Resting HeartRate of the user, as determined by the fitness data provider.<br/>
        /// Example: 65
        /// </param>
        /// <param name="userMaxHrBpm">
        /// User's maximum HeartRate based on their age, and other factors as determined by the fitness data provider.<br/>
        /// Example: 190
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartRateDataSummary(
            double? avgHrBpm,
            double? avgHrvRmssd,
            double? avgHrvSdnn,
            global::System.Collections.Generic.IList<global::Terra.HeartRateZoneData>? hrZoneData,
            double? maxHrBpm,
            double? minHrBpm,
            double? restingHrBpm,
            double? userMaxHrBpm)
        {
            this.AvgHrBpm = avgHrBpm;
            this.AvgHrvRmssd = avgHrvRmssd;
            this.AvgHrvSdnn = avgHrvSdnn;
            this.HrZoneData = hrZoneData;
            this.MaxHrBpm = maxHrBpm;
            this.MinHrBpm = minHrBpm;
            this.RestingHrBpm = restingHrBpm;
            this.UserMaxHrBpm = userMaxHrBpm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateDataSummary" /> class.
        /// </summary>
        public HeartRateDataSummary()
        {
        }
    }
}