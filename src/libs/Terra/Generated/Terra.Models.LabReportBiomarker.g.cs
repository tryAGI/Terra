
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
        /// LOINC code; omitted when the matched biomarker has no LOINC mapping. On a site-scoped (DXA) result the code identifies the (measure, site) pair rather than the measure alone, because LOINC's DXA terms are pre-coordinated — the site is baked into the term. Read it off each result; do not cache it against biomarker.key. Coverage is partial on scans: per-site body-fat percentage and the mass/lean/BMC measures have no LOINC term and omit the field.
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
        /// Canonical anatomical site keys for site-scoped (DXA) results. Closed vocabulary: the extractor may only emit a member of this set, and anything else is discarded before storage. Ordered anatomy-first, laterality-last, so a prefix match ("femur_neck") is a valid family query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AnatomicalRegionJsonConverter))]
        public global::Terra.AnatomicalRegion? Region { get; set; }

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
        /// LOINC code; omitted when the matched biomarker has no LOINC mapping. On a site-scoped (DXA) result the code identifies the (measure, site) pair rather than the measure alone, because LOINC's DXA terms are pre-coordinated — the site is baked into the term. Read it off each result; do not cache it against biomarker.key. Coverage is partial on scans: per-site body-fat percentage and the mass/lean/BMC measures have no LOINC term and omit the field.
        /// </param>
        /// <param name="panelId">
        /// References panels[].id on the enclosing session.
        /// </param>
        /// <param name="panelKey"></param>
        /// <param name="specimen"></param>
        /// <param name="region">
        /// Canonical anatomical site keys for site-scoped (DXA) results. Closed vocabulary: the extractor may only emit a member of this set, and anything else is discarded before storage. Ordered anatomy-first, laterality-last, so a prefix match ("femur_neck") is a valid family query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportBiomarker(
            string? key,
            string? displayName,
            string? loincCode,
            int? panelId,
            string? panelKey,
            string? specimen,
            global::Terra.AnatomicalRegion? region)
        {
            this.Key = key;
            this.DisplayName = displayName;
            this.LoincCode = loincCode;
            this.PanelId = panelId;
            this.PanelKey = panelKey;
            this.Specimen = specimen;
            this.Region = region;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportBiomarker" /> class.
        /// </summary>
        public LabReportBiomarker()
        {
        }

    }
}