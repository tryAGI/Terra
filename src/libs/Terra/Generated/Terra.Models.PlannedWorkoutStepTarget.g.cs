
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlannedWorkoutStepTarget
    {
        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: HEART_RATE
        /// </summary>
        /// <example>HEART_RATE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.PlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: HEART_RATE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutStepTarget(
            global::Terra.PlannedWorkoutStepTargetTargetType? targetType)
        {
            this.TargetType = targetType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutStepTarget" /> class.
        /// </summary>
        public PlannedWorkoutStepTarget()
        {
        }
    }
}