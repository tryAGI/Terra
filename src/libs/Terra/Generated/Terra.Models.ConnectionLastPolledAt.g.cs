
#nullable enable

namespace Terra
{
    /// <summary>
    /// RFC3339 timestamp of the last poll Terra ran against the provider for this connection. May be null for webhook-only flows.
    /// </summary>
    public sealed partial class ConnectionLastPolledAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}