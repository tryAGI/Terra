
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartRateData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailed")]
        public global::Terra.HeartRateDataDetailed? Detailed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::Terra.HeartRateDataSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateData" /> class.
        /// </summary>
        /// <param name="detailed"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartRateData(
            global::Terra.HeartRateDataDetailed? detailed,
            global::Terra.HeartRateDataSummary? summary)
        {
            this.Detailed = detailed;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateData" /> class.
        /// </summary>
        public HeartRateData()
        {
        }
    }
}