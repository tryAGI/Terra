
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BloodPressureSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// User's diastolic blood pressure, in mmHg<br/>
        /// Example: 80.5
        /// </summary>
        /// <example>80.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("diastolic_bp")]
        public double? DiastolicBp { get; set; }

        /// <summary>
        /// User's systolic blood pressure, in mmHg<br/>
        /// Example: 120.5
        /// </summary>
        /// <example>120.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("systolic_bp")]
        public double? SystolicBp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BloodPressureSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="diastolicBp">
        /// User's diastolic blood pressure, in mmHg<br/>
        /// Example: 80.5
        /// </param>
        /// <param name="systolicBp">
        /// User's systolic blood pressure, in mmHg<br/>
        /// Example: 120.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BloodPressureSample(
            string? timestamp,
            double? diastolicBp,
            double? systolicBp)
        {
            this.Timestamp = timestamp;
            this.DiastolicBp = diastolicBp;
            this.SystolicBp = systolicBp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BloodPressureSample" /> class.
        /// </summary>
        public BloodPressureSample()
        {
        }
    }
}