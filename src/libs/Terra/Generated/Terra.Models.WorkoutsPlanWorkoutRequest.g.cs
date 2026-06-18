
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkoutsPlanWorkoutRequest
    {
        /// <summary>
        /// Date to schedule the workout on (YYYY-MM-DD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PlannedDate { get; set; }

        /// <summary>
        /// Functional Threshold Power in watts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ftp")]
        public double? Ftp { get; set; }

        /// <summary>
        /// Maximum heart rate in BPM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_heart_rate")]
        public double? MaxHeartRate { get; set; }

        /// <summary>
        /// Threshold heart rate in BPM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_heart_rate")]
        public double? ThresholdHeartRate { get; set; }

        /// <summary>
        /// Threshold speed in m/s
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_speed")]
        public double? ThresholdSpeed { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkoutsPlanWorkoutRequest" /> class.
        /// </summary>
        /// <param name="plannedDate">
        /// Date to schedule the workout on (YYYY-MM-DD)
        /// </param>
        /// <param name="ftp">
        /// Functional Threshold Power in watts
        /// </param>
        /// <param name="maxHeartRate">
        /// Maximum heart rate in BPM
        /// </param>
        /// <param name="thresholdHeartRate">
        /// Threshold heart rate in BPM
        /// </param>
        /// <param name="thresholdSpeed">
        /// Threshold speed in m/s
        /// </param>
        /// <param name="poolLengthMeters">
        /// Pool length in meters (overrides the template value)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutsPlanWorkoutRequest(
            global::System.DateTime plannedDate,
            double? ftp,
            double? maxHeartRate,
            double? thresholdHeartRate,
            double? thresholdSpeed,
            double? poolLengthMeters)
        {
            this.PlannedDate = plannedDate;
            this.Ftp = ftp;
            this.MaxHeartRate = maxHeartRate;
            this.ThresholdHeartRate = thresholdHeartRate;
            this.ThresholdSpeed = thresholdSpeed;
            this.PoolLengthMeters = poolLengthMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsPlanWorkoutRequest" /> class.
        /// </summary>
        public WorkoutsPlanWorkoutRequest()
        {
        }

    }
}