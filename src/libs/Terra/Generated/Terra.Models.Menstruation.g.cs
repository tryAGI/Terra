
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Menstruation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.MenstruationMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("menstruation_data")]
        public global::Terra.MenstruationData? MenstruationData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Menstruation" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="menstruationData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Menstruation(
            global::Terra.MenstruationMetadata metadata,
            global::Terra.MenstruationData? menstruationData)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.MenstruationData = menstruationData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Menstruation" /> class.
        /// </summary>
        public Menstruation()
        {
        }
    }
}