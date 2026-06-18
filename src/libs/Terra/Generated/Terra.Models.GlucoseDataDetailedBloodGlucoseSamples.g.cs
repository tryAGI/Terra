
#nullable enable

namespace Terra
{
    /// <summary>
    /// List of blood glucose readings sampled throughout the day - this represents additional data points, potentially at higher frequency from the ones in blood_glucose_samples, which may come at a cost of reduced accuracy.
    /// </summary>
    public sealed partial class GlucoseDataDetailedBloodGlucoseSamples
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}