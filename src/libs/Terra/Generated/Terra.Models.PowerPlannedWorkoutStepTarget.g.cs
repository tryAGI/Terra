
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowerPlannedWorkoutStepTarget
    {
        /// <summary>
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: POWER
        /// </summary>
        /// <example>POWER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PowerPlannedWorkoutStepTargetTargetTypeJsonConverter))]
        public global::Terra.PowerPlannedWorkoutStepTargetTargetType? TargetType { get; set; }

        /// <summary>
        /// Maximum percentage of Functional Threshold Power for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 65.5
        /// </summary>
        /// <example>65.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_percentage_low")]
        public double? PowerPercentageLow { get; set; }

        /// <summary>
        /// Minimum percentage of Functional Threshold Power for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 85.5
        /// </summary>
        /// <example>85.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_percentage_high")]
        public double? PowerPercentageHigh { get; set; }

        /// <summary>
        /// Maximum power threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_watt_high")]
        public int? PowerWattHigh { get; set; }

        /// <summary>
        /// Minimum power threshold for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_watt_low")]
        public int? PowerWattLow { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: 250
        /// </summary>
        /// <example>250</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_watt")]
        public int? PowerWatt { get; set; }

        /// <summary>
        /// Ideal percentage of user's Functional Threshold Power to be maintained workout step<br/>
        /// Example: 75.5
        /// </summary>
        /// <example>75.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_percentage")]
        public double? PowerPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerPlannedWorkoutStepTarget" /> class.
        /// </summary>
        /// <param name="targetType">
        /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
        /// Example: POWER
        /// </param>
        /// <param name="powerPercentageLow">
        /// Maximum percentage of Functional Threshold Power for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 65.5
        /// </param>
        /// <param name="powerPercentageHigh">
        /// Minimum percentage of Functional Threshold Power for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 85.5
        /// </param>
        /// <param name="powerWattHigh">
        /// Maximum power threshold for the workout step - i.e. the user is to stay under this value during the workout step<br/>
        /// Example: 300
        /// </param>
        /// <param name="powerWattLow">
        /// Minimum power threshold for the workout step - i.e. the user is to stay above this value during the workout<br/>
        /// Example: 200
        /// </param>
        /// <param name="powerWatt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: 250
        /// </param>
        /// <param name="powerPercentage">
        /// Ideal percentage of user's Functional Threshold Power to be maintained workout step<br/>
        /// Example: 75.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PowerPlannedWorkoutStepTarget(
            global::Terra.PowerPlannedWorkoutStepTargetTargetType? targetType,
            double? powerPercentageLow,
            double? powerPercentageHigh,
            int? powerWattHigh,
            int? powerWattLow,
            int? powerWatt,
            double? powerPercentage)
        {
            this.TargetType = targetType;
            this.PowerPercentageLow = powerPercentageLow;
            this.PowerPercentageHigh = powerPercentageHigh;
            this.PowerWattHigh = powerWattHigh;
            this.PowerWattLow = powerWattLow;
            this.PowerWatt = powerWatt;
            this.PowerPercentage = powerPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerPlannedWorkoutStepTarget" /> class.
        /// </summary>
        public PowerPlannedWorkoutStepTarget()
        {
        }
    }
}