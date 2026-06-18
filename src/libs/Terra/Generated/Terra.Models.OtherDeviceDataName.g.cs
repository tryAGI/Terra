
#nullable enable

namespace Terra
{
    /// <summary>
    /// Device name - note that this can also be the name of the application/package which the data comes from, if coming from a data aggregator such as Google Fit.<br/>
    /// Example: Forerunner 945
    /// </summary>
    public sealed partial class OtherDeviceDataName
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}