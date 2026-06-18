
#nullable enable

namespace Terra
{
    /// <summary>
    /// RFC3339 timestamp of the most recent stored sample. May lag last_updated_at when fetches return no new data.
    /// </summary>
    public sealed partial class ConnectionMostRecentDataAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}