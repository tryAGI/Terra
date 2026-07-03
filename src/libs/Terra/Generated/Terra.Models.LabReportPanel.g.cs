
#nullable enable

namespace Terra
{
    /// <summary>
    /// A report-level grouping that results reference by panel_id.
    /// </summary>
    public sealed partial class LabReportPanel
    {
        /// <summary>
        /// Report-local ordinal; matches LabReportBiomarker.panel_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Verbatim panel header as printed on the report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Normalized dedup key (deterministic text, not a LOINC code).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportPanel" /> class.
        /// </summary>
        /// <param name="id">
        /// Report-local ordinal; matches LabReportBiomarker.panel_id.
        /// </param>
        /// <param name="name">
        /// Verbatim panel header as printed on the report.
        /// </param>
        /// <param name="key">
        /// Normalized dedup key (deterministic text, not a LOINC code).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportPanel(
            int id,
            string? name,
            string? key)
        {
            this.Id = id;
            this.Name = name;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportPanel" /> class.
        /// </summary>
        public LabReportPanel()
        {
        }

    }
}