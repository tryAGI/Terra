
#nullable enable

namespace Terra
{
    /// <summary>
    /// Completion condition of a provider planned-workout step
    /// </summary>
    public sealed partial class PlannedWorkoutDetailsStepDuration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public double? Seconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_meters")]
        public double? DistanceMeters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_below_bpm")]
        public double? HrBelowBpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_above_bpm")]
        public double? HrAboveBpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public double? Calories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_below_watts")]
        public double? PowerBelowWatts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_above_watts")]
        public double? PowerAboveWatts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reps")]
        public double? Reps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rest_seconds")]
        public double? RestSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public double? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetailsStepDuration" /> class.
        /// </summary>
        /// <param name="durationType"></param>
        /// <param name="seconds"></param>
        /// <param name="distanceMeters"></param>
        /// <param name="hrBelowBpm"></param>
        /// <param name="hrAboveBpm"></param>
        /// <param name="calories"></param>
        /// <param name="powerBelowWatts"></param>
        /// <param name="powerAboveWatts"></param>
        /// <param name="reps"></param>
        /// <param name="restSeconds"></param>
        /// <param name="steps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutDetailsStepDuration(
            int durationType,
            double? seconds,
            double? distanceMeters,
            double? hrBelowBpm,
            double? hrAboveBpm,
            double? calories,
            double? powerBelowWatts,
            double? powerAboveWatts,
            double? reps,
            double? restSeconds,
            double? steps)
        {
            this.DurationType = durationType;
            this.Seconds = seconds;
            this.DistanceMeters = distanceMeters;
            this.HrBelowBpm = hrBelowBpm;
            this.HrAboveBpm = hrAboveBpm;
            this.Calories = calories;
            this.PowerBelowWatts = powerBelowWatts;
            this.PowerAboveWatts = powerAboveWatts;
            this.Reps = reps;
            this.RestSeconds = restSeconds;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetailsStepDuration" /> class.
        /// </summary>
        public PlannedWorkoutDetailsStepDuration()
        {
        }

    }
}