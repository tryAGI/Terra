
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HRBelowPlannedWorkoutStepDuration
    {
        /// <summary>
        /// Threshold heart rate goal to complete the workout step - once the user's heart rate reaches below this value, the step will be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_below_bpm")]
        public int? HrBelowBpm { get; set; }

        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.HRBelowPlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.HRBelowPlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HRBelowPlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="hrBelowBpm">
        /// Threshold heart rate goal to complete the workout step - once the user's heart rate reaches below this value, the step will be completed
        /// </param>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HRBelowPlannedWorkoutStepDuration(
            int? hrBelowBpm,
            global::Terra.HRBelowPlannedWorkoutStepDurationDurationType? durationType)
        {
            this.HrBelowBpm = hrBelowBpm;
            this.DurationType = durationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HRBelowPlannedWorkoutStepDuration" /> class.
        /// </summary>
        public HRBelowPlannedWorkoutStepDuration()
        {
        }
    }
}