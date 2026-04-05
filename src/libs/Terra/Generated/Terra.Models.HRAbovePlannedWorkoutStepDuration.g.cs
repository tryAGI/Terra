
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HRAbovePlannedWorkoutStepDuration
    {
        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.HRAbovePlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.HRAbovePlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Threshold heart rate goal to complete the workout step - once the user's heart rate reaches above below this value, the step will be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_above_bpm")]
        public int? HrAboveBpm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HRAbovePlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
        /// <param name="hrAboveBpm">
        /// Threshold heart rate goal to complete the workout step - once the user's heart rate reaches above below this value, the step will be completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HRAbovePlannedWorkoutStepDuration(
            global::Terra.HRAbovePlannedWorkoutStepDurationDurationType? durationType,
            int? hrAboveBpm)
        {
            this.DurationType = durationType;
            this.HrAboveBpm = hrAboveBpm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HRAbovePlannedWorkoutStepDuration" /> class.
        /// </summary>
        public HRAbovePlannedWorkoutStepDuration()
        {
        }
    }
}