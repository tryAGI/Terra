
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistancePlannedWorkoutStepDuration
    {
        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.DistancePlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.DistancePlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Target distance for the workout step - once the user covers this distance, the step will be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_meters")]
        public int? DistanceMeters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistancePlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
        /// <param name="distanceMeters">
        /// Target distance for the workout step - once the user covers this distance, the step will be completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistancePlannedWorkoutStepDuration(
            global::Terra.DistancePlannedWorkoutStepDurationDurationType? durationType,
            int? distanceMeters)
        {
            this.DurationType = durationType;
            this.DistanceMeters = distanceMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistancePlannedWorkoutStepDuration" /> class.
        /// </summary>
        public DistancePlannedWorkoutStepDuration()
        {
        }
    }
}