
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HRPlannedWorkoutStepTarget
    {
        /// <summary>
        /// Maximum max heart rate percentage threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 65.5
        /// </summary>
        /// <example>65.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_percentage_low")]
        public double? HrPercentageLow { get; set; }

        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: HEART_RATE
        /// </summary>
        /// <example>HEART_RATE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.HRPlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.HRPlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Minimum heart rate percentage threshold for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 85.5
        /// </summary>
        /// <example>85.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_percentage_high")]
        public double? HrPercentageHigh { get; set; }

        /// <summary>
        /// Ideal percentage of user's maximum HR to be maintained workout step<br/>
        /// Example: 75.5
        /// </summary>
        /// <example>75.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_percentage")]
        public double? HrPercentage { get; set; }

        /// <summary>
        /// Maximum heart rate threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 175
        /// </summary>
        /// <example>175</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_bpm_high")]
        public int? HrBpmHigh { get; set; }

        /// <summary>
        /// Minimum heart rate threshold for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 130
        /// </summary>
        /// <example>130</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_bpm_low")]
        public int? HrBpmLow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HRPlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="hrPercentageLow">
        /// Maximum max heart rate percentage threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 65.5
        /// </param>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: HEART_RATE
        /// </param>
        /// <param name="hrPercentageHigh">
        /// Minimum heart rate percentage threshold for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 85.5
        /// </param>
        /// <param name="hrPercentage">
        /// Ideal percentage of user's maximum HR to be maintained workout step<br/>
        /// Example: 75.5
        /// </param>
        /// <param name="hrBpmHigh">
        /// Maximum heart rate threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 175
        /// </param>
        /// <param name="hrBpmLow">
        /// Minimum heart rate threshold for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 130
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HRPlannedWorkoutStepTarget(
            double? hrPercentageLow,
            global::Terra.HRPlannedWorkoutStepTargetTargetType? targetType,
            double? hrPercentageHigh,
            double? hrPercentage,
            int? hrBpmHigh,
            int? hrBpmLow)
        {
            this.HrPercentageLow = hrPercentageLow;
            this.TargetType = targetType;
            this.HrPercentageHigh = hrPercentageHigh;
            this.HrPercentage = hrPercentage;
            this.HrBpmHigh = hrBpmHigh;
            this.HrBpmLow = hrBpmLow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HRPlannedWorkoutStepTarget" /> class.
        /// </summary>
        public HRPlannedWorkoutStepTarget()
        {
        }
    }
}