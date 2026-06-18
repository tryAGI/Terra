
#nullable enable

namespace Terra
{
    /// <summary>
    /// Connection identifier on the developer's end, used to tie connection back to a user on the developer's platform<br/>
    /// Example: user123@email.com
    /// </summary>
    public sealed partial class TerraUserReferenceId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}