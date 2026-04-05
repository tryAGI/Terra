
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistanceDataSummary
    {
        /// <summary>
        /// Total distance covered by the user throughout the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_meters")]
        public int? DistanceMeters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation")]
        public global::Terra.ElevationData? Elevation { get; set; }

        /// <summary>
        /// Total number of elevation gain in floors climbed equivalent throughout the workout, as determined by the fitness data provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("floors_climbed")]
        public int? FloorsClimbed { get; set; }

        /// <summary>
        /// Total number of steps performed during the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("swimming")]
        public global::Terra.SwimmingData? Swimming { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceDataSummary" /> class.
        /// </summary>
        /// <param name="distanceMeters">
        /// Total distance covered by the user throughout the workout.
        /// </param>
        /// <param name="elevation"></param>
        /// <param name="floorsClimbed">
        /// Total number of elevation gain in floors climbed equivalent throughout the workout, as determined by the fitness data provider.
        /// </param>
        /// <param name="steps">
        /// Total number of steps performed during the workout.
        /// </param>
        /// <param name="swimming"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistanceDataSummary(
            int? distanceMeters,
            global::Terra.ElevationData? elevation,
            int? floorsClimbed,
            int? steps,
            global::Terra.SwimmingData? swimming)
        {
            this.DistanceMeters = distanceMeters;
            this.Elevation = elevation;
            this.FloorsClimbed = floorsClimbed;
            this.Steps = steps;
            this.Swimming = swimming;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceDataSummary" /> class.
        /// </summary>
        public DistanceDataSummary()
        {
        }
    }
}