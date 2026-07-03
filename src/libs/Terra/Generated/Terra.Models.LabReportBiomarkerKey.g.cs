
#nullable enable

namespace Terra
{
    /// <summary>
    /// Canonical biomarker slug, or null when unmatched — the sole no-match signal. Do not key off loinc_code, which can be null on a match.
    /// </summary>
    public sealed partial class LabReportBiomarkerKey
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}