
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDeleteRequest
    {
        /// <summary>
        /// List of identifiers for body metrics entries to be deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_ids")]
        public global::System.Collections.Generic.IList<string>? LogIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteRequest" /> class.
        /// </summary>
        /// <param name="logIds">
        /// List of identifiers for body metrics entries to be deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDeleteRequest(
            global::System.Collections.Generic.IList<string>? logIds)
        {
            this.LogIds = logIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteRequest" /> class.
        /// </summary>
        public BodyDeleteRequest()
        {
        }
    }
}