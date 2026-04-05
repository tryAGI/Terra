
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagData
    {
        /// <summary>
        /// Array of user-entered tags for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::Terra.TagEntry>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagData" /> class.
        /// </summary>
        /// <param name="tags">
        /// Array of user-entered tags for the day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TagData(
            global::System.Collections.Generic.IList<global::Terra.TagEntry>? tags)
        {
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagData" /> class.
        /// </summary>
        public TagData()
        {
        }
    }
}