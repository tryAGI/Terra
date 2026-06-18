
#nullable enable

namespace Terra
{
    /// <summary>
    /// Actual elevation gain of the user throughout the workout - this includes all elevation gain, and does _not_ represent net gain.<br/>
    /// Example: 550
    /// </summary>
    public sealed partial class ElevationDataGainActualMeters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}