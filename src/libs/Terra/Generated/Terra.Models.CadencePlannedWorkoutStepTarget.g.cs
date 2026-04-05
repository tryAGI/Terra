
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CadencePlannedWorkoutStepTarget
    {
        /// <summary>
        /// Ideal cadence value to be maintained for the workout step<br/>
        /// Example: 90
        /// </summary>
        /// <example>90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        public int? Cadence { get; set; }

        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: CADENCE
        /// </summary>
        /// <example>CADENCE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.CadencePlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.CadencePlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Minimum cadence threshold for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 85
        /// </summary>
        /// <example>85</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence_low")]
        public int? CadenceLow { get; set; }

        /// <summary>
        /// Maximum cadence threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 95
        /// </summary>
        /// <example>95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence_high")]
        public int? CadenceHigh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CadencePlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="cadence">
        /// Ideal cadence value to be maintained for the workout step<br/>
        /// Example: 90
        /// </param>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: CADENCE
        /// </param>
        /// <param name="cadenceLow">
        /// Minimum cadence threshold for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 85
        /// </param>
        /// <param name="cadenceHigh">
        /// Maximum cadence threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 95
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CadencePlannedWorkoutStepTarget(
            int? cadence,
            global::Terra.CadencePlannedWorkoutStepTargetTargetType? targetType,
            int? cadenceLow,
            int? cadenceHigh)
        {
            this.Cadence = cadence;
            this.TargetType = targetType;
            this.CadenceLow = cadenceLow;
            this.CadenceHigh = cadenceHigh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CadencePlannedWorkoutStepTarget" /> class.
        /// </summary>
        public CadencePlannedWorkoutStepTarget()
        {
        }
    }
}