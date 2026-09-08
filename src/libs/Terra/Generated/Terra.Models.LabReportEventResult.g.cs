
#nullable enable

namespace Terra
{
    /// <summary>
    /// One layered webhook result. Byte-identical to the retrieve result — same source, biomarker, measurement, interpretation and reference_ranges.
    /// </summary>
    public sealed partial class LabReportEventResult
    {
        /// <summary>
        /// The webhook source layer. Identical to the retrieve source layer — per-result collection date/time and region_name moved onto the shared base type, so the two cannot drift. Retained as a named type because it is published in the SDK.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.LabReportResultSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventResult" /> class.
        /// </summary>
        /// <param name="source">
        /// The webhook source layer. Identical to the retrieve source layer — per-result collection date/time and region_name moved onto the shared base type, so the two cannot drift. Retained as a named type because it is published in the SDK.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportEventResult(
            global::Terra.LabReportResultSource source)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventResult" /> class.
        /// </summary>
        public LabReportEventResult()
        {
        }

    }
}