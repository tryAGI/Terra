
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BloodPressureData(
            global::System.Collections.Generic.IList<global::Terra.BloodPressureSample>? bloodPressureSamples)
        {
            this.BloodPressureSamples = bloodPressureSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BloodPressureData" /> class.
        /// </summary>
        public BloodPressureData()
        {
        }
    }
}