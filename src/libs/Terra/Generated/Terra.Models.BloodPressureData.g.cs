
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BloodPressureData
    {
        /// <summary>
        /// List of Blood Pressure measurements sampled throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blood_pressure_samples")]
        public global::System.Collections.Generic.IList<global::Terra.BloodPressureSample>? BloodPressureSamples { get; set; }

        /// <summary>
        /// Day-average systolic blood pressure, in mmHg.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_systolic_bp")]
        public double? DayAvgSystolicBp { get; set; }

        /// <summary>
        /// Day-average diastolic blood pressure, in mmHg.<br/>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_diastolic_bp")]
        public double? DayAvgDiastolicBp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BloodPressureData" /> class.
        /// </summary>
        /// <param name="bloodPressureSamples">
        /// List of Blood Pressure measurements sampled throughout the day.
        /// </param>
        /// <param name="dayAvgSystolicBp">
        /// Day-average systolic blood pressure, in mmHg.<br/>
        /// Example: 120
        /// </param>
        /// <param name="dayAvgDiastolicBp">
        /// Day-average diastolic blood pressure, in mmHg.<br/>
        /// Example: 80
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BloodPressureData(
            global::System.Collections.Generic.IList<global::Terra.BloodPressureSample>? bloodPressureSamples,
            double? dayAvgSystolicBp,
            double? dayAvgDiastolicBp)
        {
            this.BloodPressureSamples = bloodPressureSamples;
            this.DayAvgSystolicBp = dayAvgSystolicBp;
            this.DayAvgDiastolicBp = dayAvgDiastolicBp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BloodPressureData" /> class.
        /// </summary>
        public BloodPressureData()
        {
        }

    }
}