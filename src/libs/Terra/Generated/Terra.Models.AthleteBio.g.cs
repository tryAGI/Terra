
#nullable enable

namespace Terra
{
    /// <summary>
    /// User's bio - a short description they display on their profile.<br/>
    /// Example: Passionate runner and cyclist
    /// </summary>
    public sealed partial class AthleteBio
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}