
#nullable enable

namespace Terra
{
    /// <summary>
    /// The retrieve source layer plus the specimen collection date/time (the retrieve carries these on the session, which a webhook consumer does not separately fetch).
    /// </summary>
    public sealed partial class LabReportEventResultSource
    {
        /// <summary>
        /// Specimen collection date (YYYY-MM-DD); omitted if not extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_date")]
        public string? CollectionDate { get; set; }

        /// <summary>
        /// Specimen collection time (HH:MM, 24-hour); omitted if not extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_time")]
        public string? CollectionTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventResultSource" /> class.
        /// </summary>
        /// <param name="collectionDate">
        /// Specimen collection date (YYYY-MM-DD); omitted if not extracted.
        /// </param>
        /// <param name="collectionTime">
        /// Specimen collection time (HH:MM, 24-hour); omitted if not extracted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportEventResultSource(
            string? collectionDate,
            string? collectionTime)
        {
            this.CollectionDate = collectionDate;
            this.CollectionTime = collectionTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventResultSource" /> class.
        /// </summary>
        public LabReportEventResultSource()
        {
        }

    }
}