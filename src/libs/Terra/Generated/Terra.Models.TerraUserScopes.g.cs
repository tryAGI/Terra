
#nullable enable

namespace Terra
{
    /// <summary>
    /// (when available) Permissions granted by the user during authentication - to be used as debugging metadata<br/>
    /// Example: activity:read,sleep:read
    /// </summary>
    public sealed partial class TerraUserScopes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}