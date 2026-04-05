
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowerBelowPlannedWorkoutStepDuration
    {
        /// <summary>
        /// Threshold power goal to complete the workout step - once the user reaches below this power level, the step will be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_below_watts")]
        public int? PowerBelowWatts { get; set; }

        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PowerBelowPlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.PowerBelowPlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerBelowPlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="powerBelowWatts">
        /// Threshold power goal to complete the workout step - once the user reaches below this power level, the step will be completed
        /// </param>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PowerBelowPlannedWorkoutStepDuration(
            int? powerBelowWatts,
            global::Terra.PowerBelowPlannedWorkoutStepDurationDurationType? durationType)
        {
            this.PowerBelowWatts = powerBelowWatts;
            this.DurationType = durationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerBelowPlannedWorkoutStepDuration" /> class.
        /// </summary>
        public PowerBelowPlannedWorkoutStepDuration()
        {
        }
    }
}