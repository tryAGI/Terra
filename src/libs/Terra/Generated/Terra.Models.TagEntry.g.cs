
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagEntry
    {
        /// <summary>
        /// Time with which the tag is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>1999-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Tag name, representing a certain event associated with the user's day.<br/>
        /// Example: hot_shower
        /// </summary>
        /// <example>hot_shower</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagName { get; set; }

        /// <summary>
        /// User-input notes associated with the given tag.<br/>
        /// Example: Felt refreshed after
        /// </summary>
        /// <example>Felt refreshed after</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Notes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagEntry" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the tag is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="tagName">
        /// Tag name, representing a certain event associated with the user's day.<br/>
        /// Example: hot_shower
        /// </param>
        /// <param name="notes">
        /// User-input notes associated with the given tag.<br/>
        /// Example: Felt refreshed after
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TagEntry(
            string timestamp,
            string tagName,
            string notes)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.TagName = tagName ?? throw new global::System.ArgumentNullException(nameof(tagName));
            this.Notes = notes ?? throw new global::System.ArgumentNullException(nameof(notes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagEntry" /> class.
        /// </summary>
        public TagEntry()
        {
        }
    }
}