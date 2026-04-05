
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepsPlannedWorkoutStepDuration
    {
        /// <summary>
        /// Target number of steps for the workout step - once the user performs this number of steps, the step will be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.StepsPlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.StepsPlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepsPlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="steps">
        /// Target number of steps for the workout step - once the user performs this number of steps, the step will be completed
        /// </param>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepsPlannedWorkoutStepDuration(
            int? steps,
            global::Terra.StepsPlannedWorkoutStepDurationDurationType? durationType)
        {
            this.Steps = steps;
            this.DurationType = durationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepsPlannedWorkoutStepDuration" /> class.
        /// </summary>
        public StepsPlannedWorkoutStepDuration()
        {
        }
    }
}