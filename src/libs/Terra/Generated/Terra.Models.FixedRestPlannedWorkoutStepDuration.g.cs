
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FixedRestPlannedWorkoutStepDuration
    {
        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.FixedRestPlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.FixedRestPlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Time duration to be elapsed for the rest period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rest_seconds")]
        public int? RestSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FixedRestPlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
        /// <param name="restSeconds">
        /// Time duration to be elapsed for the rest period
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FixedRestPlannedWorkoutStepDuration(
            global::Terra.FixedRestPlannedWorkoutStepDurationDurationType? durationType,
            int? restSeconds)
        {
            this.DurationType = durationType;
            this.RestSeconds = restSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FixedRestPlannedWorkoutStepDuration" /> class.
        /// </summary>
        public FixedRestPlannedWorkoutStepDuration()
        {
        }
    }
}