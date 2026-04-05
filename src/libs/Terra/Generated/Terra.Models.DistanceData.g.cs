
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistanceData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailed")]
        public global::Terra.DistanceDataDetailed? Detailed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::Terra.DistanceDataSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceData" /> class.
        /// </summary>
        /// <param name="detailed"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistanceData(
            global::Terra.DistanceDataDetailed? detailed,
            global::Terra.DistanceDataSummary? summary)
        {
            this.Detailed = detailed;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceData" /> class.
        /// </summary>
        public DistanceData()
        {
        }
    }
}