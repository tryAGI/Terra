
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepetitionPlannedWorkoutStepTarget
    {
        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: REPETITION
        /// </summary>
        /// <example>REPETITION</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.RepetitionPlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.RepetitionPlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Number of repetitions of the workout step to be performed<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetitions")]
        public double? Repetitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepetitionPlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: REPETITION
        /// </param>
        /// <param name="repetitions">
        /// Number of repetitions of the workout step to be performed<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepetitionPlannedWorkoutStepTarget(
            global::Terra.RepetitionPlannedWorkoutStepTargetTargetType? targetType,
            double? repetitions)
        {
            this.TargetType = targetType;
            this.Repetitions = repetitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepetitionPlannedWorkoutStepTarget" /> class.
        /// </summary>
        public RepetitionPlannedWorkoutStepTarget()
        {
        }
    }
}