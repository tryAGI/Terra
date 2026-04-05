
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistanceDataDetailed
    {
        /// <summary>
        /// Array of detailed samples of distance covered throughout the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_samples")]
        public global::System.Collections.Generic.IList<global::Terra.DistanceSample>? DistanceSamples { get; set; }

        /// <summary>
        /// Array of detailed samples of elevation throughout the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation_samples")]
        public global::System.Collections.Generic.IList<global::Terra.ElevationSample>? ElevationSamples { get; set; }

        /// <summary>
        /// Array of detailed samples of floors climbed throughout the workout, as determined by the fitness data provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("floors_climbed_samples")]
        public global::System.Collections.Generic.IList<global::Terra.FloorsClimbedSample>? FloorsClimbedSamples { get; set; }

        /// <summary>
        /// Array of detailed samples of steps performed throughout the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_samples")]
        public global::System.Collections.Generic.IList<global::Terra.StepSample>? StepSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceDataDetailed" /> class.
        /// </summary>
        /// <param name="distanceSamples">
        /// Array of detailed samples of distance covered throughout the workout.
        /// </param>
        /// <param name="elevationSamples">
        /// Array of detailed samples of elevation throughout the workout.
        /// </param>
        /// <param name="floorsClimbedSamples">
        /// Array of detailed samples of floors climbed throughout the workout, as determined by the fitness data provider.
        /// </param>
        /// <param name="stepSamples">
        /// Array of detailed samples of steps performed throughout the workout.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistanceDataDetailed(
            global::System.Collections.Generic.IList<global::Terra.DistanceSample>? distanceSamples,
            global::System.Collections.Generic.IList<global::Terra.ElevationSample>? elevationSamples,
            global::System.Collections.Generic.IList<global::Terra.FloorsClimbedSample>? floorsClimbedSamples,
            global::System.Collections.Generic.IList<global::Terra.StepSample>? stepSamples)
        {
            this.DistanceSamples = distanceSamples;
            this.ElevationSamples = elevationSamples;
            this.FloorsClimbedSamples = floorsClimbedSamples;
            this.StepSamples = stepSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceDataDetailed" /> class.
        /// </summary>
        public DistanceDataDetailed()
        {
        }
    }
}