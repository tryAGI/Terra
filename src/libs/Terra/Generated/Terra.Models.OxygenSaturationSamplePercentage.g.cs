
#nullable enable

namespace Terra
{
    /// <summary>
    /// User's oxygen saturation percentage - referring to either SpO2 or SmO2, based on the `type` field<br/>
    /// Example: 98
    /// </summary>
    public sealed partial class OxygenSaturationSamplePercentage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}