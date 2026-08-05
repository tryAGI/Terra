
#nullable enable

namespace Terra
{
    /// <summary>
    /// Mean absolute skin temperature in degrees Celsius over the sleep window. Null for providers that only report a baseline deviation.<br/>
    /// Example: 33.7
    /// </summary>
    public sealed partial class SleepTemperatureDataAvgSkinTemperatureCelsius
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}