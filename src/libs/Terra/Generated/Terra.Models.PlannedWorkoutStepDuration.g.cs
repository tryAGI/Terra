
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlannedWorkoutStepDuration
    {
        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.PlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutStepDuration(
            global::Terra.PlannedWorkoutStepDurationDurationType? durationType)
        {
            this.DurationType = durationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutStepDuration" /> class.
        /// </summary>
        public PlannedWorkoutStepDuration()
        {
        }
    }
}