
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RespirationData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breaths_data")]
        public global::Terra.BreathsData? BreathsData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oxygen_saturation_data")]
        public global::Terra.OxygenSaturationData? OxygenSaturationData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snoring_data")]
        public global::Terra.SnoringData? SnoringData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RespirationData" /> class.
        /// </summary>
        /// <param name="breathsData"></param>
        /// <param name="oxygenSaturationData"></param>
        /// <param name="snoringData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RespirationData(
            global::Terra.BreathsData? breathsData,
            global::Terra.OxygenSaturationData? oxygenSaturationData,
            global::Terra.SnoringData? snoringData)
        {
            this.BreathsData = breathsData;
            this.OxygenSaturationData = oxygenSaturationData;
            this.SnoringData = snoringData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RespirationData" /> class.
        /// </summary>
        public RespirationData()
        {
        }
    }
}