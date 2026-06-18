
#nullable enable

namespace Terra
{
    /// <summary>
    /// Athlete-specific metrics used to personalise workout targets for one planned workout
    /// </summary>
    public sealed partial class AthleteMetrics
    {
        /// <summary>
        /// Threshold heart rate in BPM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_heart_rate")]
        public double? ThresholdHeartRate { get; set; }

        /// <summary>
        /// Maximum heart rate in BPM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_heart_rate")]
        public double? MaxHeartRate { get; set; }

        /// <summary>
        /// Threshold speed in m/s
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_speed")]
        public double? ThresholdSpeed { get; set; }

        /// <summary>
        /// Functional Threshold Power in watts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ftp")]
        public double? Ftp { get; set; }

        /// <summary>
        /// Pool length in meters (overrides the template value)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_length_meters")]
        public double? PoolLengthMeters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AthleteMetrics" /> class.
        /// </summary>
        /// <param name="thresholdHeartRate">
        /// Threshold heart rate in BPM
        /// </param>
        /// <param name="maxHeartRate">
        /// Maximum heart rate in BPM
        /// </param>
        /// <param name="thresholdSpeed">
        /// Threshold speed in m/s
        /// </param>
        /// <param name="ftp">
        /// Functional Threshold Power in watts
        /// </param>
        /// <param name="poolLengthMeters">
        /// Pool length in meters (overrides the template value)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AthleteMetrics(
            double? thresholdHeartRate,
            double? maxHeartRate,
            double? thresholdSpeed,
            double? ftp,
            double? poolLengthMeters)
        {
            this.ThresholdHeartRate = thresholdHeartRate;
            this.MaxHeartRate = maxHeartRate;
            this.ThresholdSpeed = thresholdSpeed;
            this.Ftp = ftp;
            this.PoolLengthMeters = poolLengthMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AthleteMetrics" /> class.
        /// </summary>
        public AthleteMetrics()
        {
        }

    }
}