
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeedPlannedWorkoutStepTarget
    {
        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: SPEED
        /// </summary>
        /// <example>SPEED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.SpeedPlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.SpeedPlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Maximum speed threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 85.5
        /// </summary>
        /// <example>85.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_percentage_high")]
        public double? SpeedPercentageHigh { get; set; }

        /// <summary>
        /// Minimum speed threshold for the workout step - i.e. the user is to stay above this value during the workout step<br/>
        /// Example: 65.5
        /// </summary>
        /// <example>65.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_percentage_low")]
        public double? SpeedPercentageLow { get; set; }

        /// <summary>
        /// Ideal percentage of user's Threshold Speed, based off their Threshold Pace, to be maintained workout step. Usually, the Threshold Pace is defined as the pace one could race at for 50 to 60 minutes<br/>
        /// Example: 75.5
        /// </summary>
        /// <example>75.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_percentage")]
        public double? SpeedPercentage { get; set; }

        /// <summary>
        /// Ideal speed value to be maintained for the workout step<br/>
        /// Example: 4.2
        /// </summary>
        /// <example>4.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_meters_per_second")]
        public double? SpeedMetersPerSecond { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedPlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: SPEED
        /// </param>
        /// <param name="speedPercentageHigh">
        /// Maximum speed threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 85.5
        /// </param>
        /// <param name="speedPercentageLow">
        /// Minimum speed threshold for the workout step - i.e. the user is to stay above this value during the workout step<br/>
        /// Example: 65.5
        /// </param>
        /// <param name="speedPercentage">
        /// Ideal percentage of user's Threshold Speed, based off their Threshold Pace, to be maintained workout step. Usually, the Threshold Pace is defined as the pace one could race at for 50 to 60 minutes<br/>
        /// Example: 75.5
        /// </param>
        /// <param name="speedMetersPerSecond">
        /// Ideal speed value to be maintained for the workout step<br/>
        /// Example: 4.2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeedPlannedWorkoutStepTarget(
            global::Terra.SpeedPlannedWorkoutStepTargetTargetType? targetType,
            double? speedPercentageHigh,
            double? speedPercentageLow,
            double? speedPercentage,
            double? speedMetersPerSecond)
        {
            this.TargetType = targetType;
            this.SpeedPercentageHigh = speedPercentageHigh;
            this.SpeedPercentageLow = speedPercentageLow;
            this.SpeedPercentage = speedPercentage;
            this.SpeedMetersPerSecond = speedMetersPerSecond;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedPlannedWorkoutStepTarget" /> class.
        /// </summary>
        public SpeedPlannedWorkoutStepTarget()
        {
        }
    }
}