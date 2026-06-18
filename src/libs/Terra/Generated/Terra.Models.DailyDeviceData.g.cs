
#nullable enable

namespace Terra
{
    /// <summary>
    /// Object containing information on the device which recorded data for the day.
    /// </summary>
    public sealed partial class DailyDeviceData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}