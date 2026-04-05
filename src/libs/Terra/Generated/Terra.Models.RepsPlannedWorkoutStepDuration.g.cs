
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepsPlannedWorkoutStepDuration
    {
        /// <summary>
        /// Target number of reps for the workout step - once the user completes this rep target, the step will be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reps")]
        public int? Reps { get; set; }

        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.RepsPlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.RepsPlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepsPlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="reps">
        /// Target number of reps for the workout step - once the user completes this rep target, the step will be completed
        /// </param>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepsPlannedWorkoutStepDuration(
            int? reps,
            global::Terra.RepsPlannedWorkoutStepDurationDurationType? durationType)
        {
            this.Reps = reps;
            this.DurationType = durationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepsPlannedWorkoutStepDuration" /> class.
        /// </summary>
        public RepsPlannedWorkoutStepDuration()
        {
        }
    }
}