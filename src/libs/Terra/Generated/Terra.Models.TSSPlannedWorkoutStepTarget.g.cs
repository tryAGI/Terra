
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TSSPlannedWorkoutStepTarget
    {
        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: TSS
        /// </summary>
        /// <example>TSS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.TSSPlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.TSSPlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Planned Training Stress Score to be achieved for the workout step<br/>
        /// Example: 100.5
        /// </summary>
        /// <example>100.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tss")]
        public double? Tss { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TSSPlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: TSS
        /// </param>
        /// <param name="tss">
        /// Planned Training Stress Score to be achieved for the workout step<br/>
        /// Example: 100.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TSSPlannedWorkoutStepTarget(
            global::Terra.TSSPlannedWorkoutStepTargetTargetType? targetType,
            double? tss)
        {
            this.TargetType = targetType;
            this.Tss = tss;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TSSPlannedWorkoutStepTarget" /> class.
        /// </summary>
        public TSSPlannedWorkoutStepTarget()
        {
        }
    }
}