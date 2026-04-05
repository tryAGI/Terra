
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SwimStrokePlannedWorkoutStepTarget
    {
        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: SWIM_STROKE
        /// </summary>
        /// <example>SWIM_STROKE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.SwimStrokePlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.SwimStrokePlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Number of swim strokes to be performed during the workout step<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("swim_strokes")]
        public int? SwimStrokes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SwimStrokePlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: SWIM_STROKE
        /// </param>
        /// <param name="swimStrokes">
        /// Number of swim strokes to be performed during the workout step<br/>
        /// Example: 50
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SwimStrokePlannedWorkoutStepTarget(
            global::Terra.SwimStrokePlannedWorkoutStepTargetTargetType? targetType,
            int? swimStrokes)
        {
            this.TargetType = targetType;
            this.SwimStrokes = swimStrokes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwimStrokePlannedWorkoutStepTarget" /> class.
        /// </summary>
        public SwimStrokePlannedWorkoutStepTarget()
        {
        }
    }
}