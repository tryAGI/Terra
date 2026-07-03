
#nullable enable

namespace Terra
{
    /// <summary>
    /// One layered result: verbatim source, normalized biomarker identity, one typed measurement, and the interpretation. measurement and interpretation are byte-identical to the webhook payload.
    /// </summary>
    public sealed partial class LabReportResult
    {
        /// <summary>
        /// The verbatim provenance layer — what the report literally printed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.LabReportResultSource Source { get; set; }

        /// <summary>
        /// The normalized identity layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("biomarker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.LabReportBiomarker Biomarker { get; set; }

        /// <summary>
        /// The single typed value of a result. Exactly one value field is set, named by type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.LabReportMeasurement Measurement { get; set; }

        /// <summary>
        /// The per-result abnormality layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interpretation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.LabReportInterpretation Interpretation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_ranges")]
        public global::System.Collections.Generic.IList<global::Terra.LabReportReferenceRange>? ReferenceRanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportResult" /> class.
        /// </summary>
        /// <param name="source">
        /// The verbatim provenance layer — what the report literally printed.
        /// </param>
        /// <param name="biomarker">
        /// The normalized identity layer.
        /// </param>
        /// <param name="measurement">
        /// The single typed value of a result. Exactly one value field is set, named by type.
        /// </param>
        /// <param name="interpretation">
        /// The per-result abnormality layer.
        /// </param>
        /// <param name="referenceRanges"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportResult(
            global::Terra.LabReportResultSource source,
            global::Terra.LabReportBiomarker biomarker,
            global::Terra.LabReportMeasurement measurement,
            global::Terra.LabReportInterpretation interpretation,
            global::System.Collections.Generic.IList<global::Terra.LabReportReferenceRange>? referenceRanges)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Biomarker = biomarker ?? throw new global::System.ArgumentNullException(nameof(biomarker));
            this.Measurement = measurement ?? throw new global::System.ArgumentNullException(nameof(measurement));
            this.Interpretation = interpretation ?? throw new global::System.ArgumentNullException(nameof(interpretation));
            this.ReferenceRanges = referenceRanges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportResult" /> class.
        /// </summary>
        public LabReportResult()
        {
        }

    }
}