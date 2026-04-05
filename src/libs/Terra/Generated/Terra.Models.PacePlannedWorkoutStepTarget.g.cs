
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PacePlannedWorkoutStepTarget
    {
        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: PACE
        /// </summary>
        /// <example>PACE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PacePlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.PacePlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Ideal pace value to be maintained for the workout step<br/>
        /// Example: 5.5
        /// </summary>
        /// <example>5.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pace_minutes_per_kilometer")]
        public double? PaceMinutesPerKilometer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PacePlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: PACE
        /// </param>
        /// <param name="paceMinutesPerKilometer">
        /// Ideal pace value to be maintained for the workout step<br/>
        /// Example: 5.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PacePlannedWorkoutStepTarget(
            global::Terra.PacePlannedWorkoutStepTargetTargetType? targetType,
            double? paceMinutesPerKilometer)
        {
            this.TargetType = targetType;
            this.PaceMinutesPerKilometer = paceMinutesPerKilometer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PacePlannedWorkoutStepTarget" /> class.
        /// </summary>
        public PacePlannedWorkoutStepTarget()
        {
        }
    }
}