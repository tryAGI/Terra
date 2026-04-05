
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowerAbovePlannedWorkoutStepDuration
    {
        /// <summary>
        /// Threshold power goal to complete the workout step - once the user reaches above this power level, the step will be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_above_watts")]
        public int? PowerAboveWatts { get; set; }

        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PowerAbovePlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.PowerAbovePlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerAbovePlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="powerAboveWatts">
        /// Threshold power goal to complete the workout step - once the user reaches above this power level, the step will be completed
        /// </param>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PowerAbovePlannedWorkoutStepDuration(
            int? powerAboveWatts,
            global::Terra.PowerAbovePlannedWorkoutStepDurationDurationType? durationType)
        {
            this.PowerAboveWatts = powerAboveWatts;
            this.DurationType = durationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerAbovePlannedWorkoutStepDuration" /> class.
        /// </summary>
        public PowerAbovePlannedWorkoutStepDuration()
        {
        }
    }
}