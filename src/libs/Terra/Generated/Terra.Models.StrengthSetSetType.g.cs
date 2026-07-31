
#nullable enable

namespace Terra
{
    /// <summary>
    /// The type of set as reported by the source, such as normal, warmup, dropset or failure. Open enum — handle unknown values gracefully. unknown when the source does not classify the set.<br/>
    /// Example: normal
    /// </summary>
    public sealed partial class StrengthSetSetType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}