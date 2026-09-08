
#nullable enable

namespace Terra
{
    /// <summary>
    /// The verbatim provenance layer — what the report literally printed.
    /// </summary>
    public sealed partial class LabReportResultSource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel")]
        public string? Panel { get; set; }

        /// <summary>
        /// Raw value string as printed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        public string? Units { get; set; }

        /// <summary>
        /// Verbatim flag; the coded form is under interpretation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        public string? Flag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_text")]
        public string? ReferenceText { get; set; }

        /// <summary>
        /// Anatomical site label exactly as printed on the report, in the original language. Present whenever the report shows a site, including when no canonical region key matched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_name")]
        public string? RegionName { get; set; }

        /// <summary>
        /// Date this specific measurement was taken (YYYY-MM-DD). Distinguishes a prior scan in a trend table from the current one; omitted if not shown per result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_date")]
        public string? CollectionDate { get; set; }

        /// <summary>
        /// Time this specific measurement was taken (HH:MM, 24-hour); omitted if not shown per result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_time")]
        public string? CollectionTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportResultSource" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="panel"></param>
        /// <param name="value">
        /// Raw value string as printed.
        /// </param>
        /// <param name="units"></param>
        /// <param name="flag">
        /// Verbatim flag; the coded form is under interpretation.
        /// </param>
        /// <param name="method"></param>
        /// <param name="notes"></param>
        /// <param name="referenceText"></param>
        /// <param name="regionName">
        /// Anatomical site label exactly as printed on the report, in the original language. Present whenever the report shows a site, including when no canonical region key matched.
        /// </param>
        /// <param name="collectionDate">
        /// Date this specific measurement was taken (YYYY-MM-DD). Distinguishes a prior scan in a trend table from the current one; omitted if not shown per result.
        /// </param>
        /// <param name="collectionTime">
        /// Time this specific measurement was taken (HH:MM, 24-hour); omitted if not shown per result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportResultSource(
            string? name,
            string? panel,
            string? value,
            string? units,
            string? flag,
            string? method,
            string? notes,
            string? referenceText,
            string? regionName,
            string? collectionDate,
            string? collectionTime)
        {
            this.Name = name;
            this.Panel = panel;
            this.Value = value;
            this.Units = units;
            this.Flag = flag;
            this.Method = method;
            this.Notes = notes;
            this.ReferenceText = referenceText;
            this.RegionName = regionName;
            this.CollectionDate = collectionDate;
            this.CollectionTime = collectionTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportResultSource" /> class.
        /// </summary>
        public LabReportResultSource()
        {
        }

    }
}