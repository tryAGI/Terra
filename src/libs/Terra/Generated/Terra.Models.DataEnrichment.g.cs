
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataEnrichment
    {
        /// <summary>
        /// User's stress score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress_score")]
        public int? StressScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEnrichment" /> class.
        /// </summary>
        /// <param name="stressScore">
        /// User's stress score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataEnrichment(
            int? stressScore)
        {
            this.StressScore = stressScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEnrichment" /> class.
        /// </summary>
        public DataEnrichment()
        {
        }
    }
}