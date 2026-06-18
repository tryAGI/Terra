
#nullable enable

namespace Terra
{
    /// <summary>
    /// External user identifier provided at connect time.<br/>
    /// Example: user_external_ref_123
    /// </summary>
    public sealed partial class ConnectionReferenceId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}