
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlucoseData
    {
        /// <summary>
        /// List of blood glucose readings sampled throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blood_glucose_samples")]
        public global::System.Collections.Generic.IList<global::Terra.GlucoseDataSample>? BloodGlucoseSamples { get; set; }

        /// <summary>
        /// List of blood glucose readings sampled throughout the day - this represents additional data points, potentially at higher frequency from the ones in blood_glucose_samples, which may come at a cost of reduced accuracy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailed_blood_glucose_samples")]
        public global::System.Collections.Generic.IList<global::Terra.GlucoseDataSample>? DetailedBloodGlucoseSamples { get; set; }

        /// <summary>
        /// User's average glucose level throughout the day.<br/>
        /// Example: 92.5
        /// </summary>
        /// <example>92.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_blood_glucose_mg_per_dL")]
        public double? DayAvgBloodGlucoseMgPerDL { get; set; }

        /// <summary>
        /// GMI (Glucose Management Indicator) is a metric derived from continuous glucose monitoring (CGM) data that estimates average glucose levels to help guide diabetes management, without implying a precise match to laboratory A1C.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gmi")]
        public double? Gmi { get; set; }

        /// <summary>
        /// Time that the user's glucose is within acceptable range (not hyper or hypoglycemic).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_in_range")]
        public double? TimeInRange { get; set; }

        /// <summary>
        /// Number of data points recorded by the sensor throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensor_usage")]
        public int? SensorUsage { get; set; }

        /// <summary>
        /// List of glucose percentile samples throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_patterns")]
        public global::System.Collections.Generic.IList<global::Terra.DailyPatternSample>? DailyPatterns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlucoseData" /> class.
        /// </summary>
        /// <param name="bloodGlucoseSamples">
        /// List of blood glucose readings sampled throughout the day.
        /// </param>
        /// <param name="detailedBloodGlucoseSamples">
        /// List of blood glucose readings sampled throughout the day - this represents additional data points, potentially at higher frequency from the ones in blood_glucose_samples, which may come at a cost of reduced accuracy.
        /// </param>
        /// <param name="dayAvgBloodGlucoseMgPerDL">
        /// User's average glucose level throughout the day.<br/>
        /// Example: 92.5
        /// </param>
        /// <param name="gmi">
        /// GMI (Glucose Management Indicator) is a metric derived from continuous glucose monitoring (CGM) data that estimates average glucose levels to help guide diabetes management, without implying a precise match to laboratory A1C.
        /// </param>
        /// <param name="timeInRange">
        /// Time that the user's glucose is within acceptable range (not hyper or hypoglycemic).
        /// </param>
        /// <param name="sensorUsage">
        /// Number of data points recorded by the sensor throughout the day.
        /// </param>
        /// <param name="dailyPatterns">
        /// List of glucose percentile samples throughout the day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlucoseData(
            global::System.Collections.Generic.IList<global::Terra.GlucoseDataSample>? bloodGlucoseSamples,
            global::System.Collections.Generic.IList<global::Terra.GlucoseDataSample>? detailedBloodGlucoseSamples,
            double? dayAvgBloodGlucoseMgPerDL,
            double? gmi,
            double? timeInRange,
            int? sensorUsage,
            global::System.Collections.Generic.IList<global::Terra.DailyPatternSample>? dailyPatterns)
        {
            this.BloodGlucoseSamples = bloodGlucoseSamples;
            this.DetailedBloodGlucoseSamples = detailedBloodGlucoseSamples;
            this.DayAvgBloodGlucoseMgPerDL = dayAvgBloodGlucoseMgPerDL;
            this.Gmi = gmi;
            this.TimeInRange = timeInRange;
            this.SensorUsage = sensorUsage;
            this.DailyPatterns = dailyPatterns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlucoseData" /> class.
        /// </summary>
        public GlucoseData()
        {
        }
    }
}