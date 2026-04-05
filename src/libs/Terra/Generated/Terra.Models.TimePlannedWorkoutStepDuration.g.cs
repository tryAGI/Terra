
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimePlannedWorkoutStepDuration
    {
        /// <summary>
        /// Time duration to be elapsed for the workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public int? Seconds { get; set; }

        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.TimePlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.TimePlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimePlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="seconds">
        /// Time duration to be elapsed for the workout step
        /// </param>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimePlannedWorkoutStepDuration(
            int? seconds,
            global::Terra.TimePlannedWorkoutStepDurationDurationType? durationType)
        {
            this.Seconds = seconds;
            this.DurationType = durationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimePlannedWorkoutStepDuration" /> class.
        /// </summary>
        public TimePlannedWorkoutStepDuration()
        {
        }
    }
}