
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PolylineMapData
    {
        /// <summary>
        /// The polyline representation of the user's trajectory throughout the workout<br/>
        /// Example: }_p~iF~ps|U_ulLnnqC_mqNvxq`@
        /// </summary>
        /// <example>}_p~iF~ps|U_ulLnnqC_mqNvxq`@</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_polyline")]
        public string? SummaryPolyline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolylineMapData" /> class.
        /// </summary>
        /// <param name="summaryPolyline">
        /// The polyline representation of the user's trajectory throughout the workout<br/>
        /// Example: }_p~iF~ps|U_ulLnnqC_mqNvxq`@
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolylineMapData(
            string? summaryPolyline)
        {
            this.SummaryPolyline = summaryPolyline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolylineMapData" /> class.
        /// </summary>
        public PolylineMapData()
        {
        }
    }
}