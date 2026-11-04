
#nullable enable

namespace Terra
{
    /// <summary>
    /// Target intensity range for a step (e.g. heart-rate or power zone). The unit of value, value_low and value_high depends on target_type: heart_rate in BPM; power in watts; speed in metres per second; pace in seconds per kilometre, so 4:30/km is 270, not 4.5; cadence in rpm or steps per minute; rpe from 1 to 10; heart_rate_zone (1-5) and power_zone (1-7) as zone numbers; the *_percentage types in percent of the athlete parameter given when planning (max_heart_rate, threshold_heart_rate, ftp or threshold_speed).
    /// </summary>
    public sealed partial class IntensityTarget
    {
        /// <summary>
        /// Quantity an intensity target constrains
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.WorkoutStepTargetType TargetType { get; set; }

        /// <summary>
        /// Single target value, in the unit for target_type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Lower bound of the target range, in the unit for target_type. For pace, the lower number is the faster pace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_low")]
        public double? ValueLow { get; set; }

        /// <summary>
        /// Upper bound of the target range, in the unit for target_type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_high")]
        public double? ValueHigh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntensityTarget" /> class.
        /// </summary>
        /// <param name="targetType">
        /// Quantity an intensity target constrains
        /// </param>
        /// <param name="value">
        /// Single target value, in the unit for target_type
        /// </param>
        /// <param name="valueLow">
        /// Lower bound of the target range, in the unit for target_type. For pace, the lower number is the faster pace
        /// </param>
        /// <param name="valueHigh">
        /// Upper bound of the target range, in the unit for target_type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntensityTarget(
            global::Terra.WorkoutStepTargetType targetType,
            double? value,
            double? valueLow,
            double? valueHigh)
        {
            this.TargetType = targetType;
            this.Value = value;
            this.ValueLow = valueLow;
            this.ValueHigh = valueHigh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntensityTarget" /> class.
        /// </summary>
        public IntensityTarget()
        {
        }

    }
}