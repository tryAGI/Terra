
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IFPlannedWorkoutStepTarget
    {
        /// <summary>
        /// Maximum Intensity Factor to be achieved for the workout step<br/>
        /// Example: 1.2
        /// </summary>
        /// <example>1.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("if_high")]
        public double? IfHigh { get; set; }

        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: IF
        /// </summary>
        /// <example>IF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.IFPlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.IFPlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Minimum Intensity Factor to be achieved for the workout step<br/>
        /// Example: 0.8
        /// </summary>
        /// <example>0.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("if_low")]
        public double? IfLow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IFPlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="ifHigh">
        /// Maximum Intensity Factor to be achieved for the workout step<br/>
        /// Example: 1.2
        /// </param>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: IF
        /// </param>
        /// <param name="ifLow">
        /// Minimum Intensity Factor to be achieved for the workout step<br/>
        /// Example: 0.8
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IFPlannedWorkoutStepTarget(
            double? ifHigh,
            global::Terra.IFPlannedWorkoutStepTargetTargetType? targetType,
            double? ifLow)
        {
            this.IfHigh = ifHigh;
            this.TargetType = targetType;
            this.IfLow = ifLow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IFPlannedWorkoutStepTarget" /> class.
        /// </summary>
        public IFPlannedWorkoutStepTarget()
        {
        }
    }
}