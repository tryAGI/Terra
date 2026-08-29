
#nullable enable

namespace Terra
{
    /// <summary>
    /// The normalized identity layer.
    /// </summary>
    public sealed partial class LabReportBiomarker
    {
        /// <summary>
        /// Canonical biomarker slug, or null when unmatched — the sole no-match signal. Do not key off loinc_code, which can be null on a match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// LOINC code; omitted when the matched biomarker has no LOINC mapping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loinc_code")]
        public string? LoincCode { get; set; }

        /// <summary>
        /// References panels[].id on the enclosing session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel_id")]
        public int? PanelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel_key")]
        public string? PanelKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specimen")]
        public string? Specimen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportBiomarker" /> class.
        /// </summary>
        /// <param name="key">
        /// Canonical biomarker slug, or null when unmatched — the sole no-match signal. Do not key off loinc_code, which can be null on a match.
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="loincCode">
        /// LOINC code; omitted when the matched biomarker has no LOINC mapping.
        /// </param>
        /// <param name="panelId">
        /// References panels[].id on the enclosing session.
        /// </param>
        /// <param name="panelKey"></param>
        /// <param name="specimen"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportBiomarker(
            string? key,
            string? displayName,
            string? loincCode,
            int? panelId,
            string? panelKey,
            string? specimen)
        {
            this.Key = key;
            this.DisplayName = displayName;
            this.LoincCode = loincCode;
            this.PanelId = panelId;
            this.PanelKey = panelKey;
            this.Specimen = specimen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportBiomarker" /> class.
        /// </summary>
        public LabReportBiomarker()
        {
        }

    }
}