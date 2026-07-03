
#nullable enable

namespace Terra
{
    /// <summary>
    /// The per-result abnormality layer.
    /// </summary>
    public sealed partial class LabReportInterpretation
    {
        /// <summary>
        /// Coded signal (`high`/`low`/`normal`), or null when there is no signal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        public string? Flag { get; set; }

        /// <summary>
        /// The lab's verbatim flag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag_raw")]
        public string? FlagRaw { get; set; }

        /// <summary>
        /// Provenance of `flag` — `report`, `computed`, or `none`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Bounds of the reference range the flag was judged against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applied_range")]
        public global::Terra.LabReportAppliedRange? AppliedRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportInterpretation" /> class.
        /// </summary>
        /// <param name="source">
        /// Provenance of `flag` — `report`, `computed`, or `none`.
        /// </param>
        /// <param name="flag">
        /// Coded signal (`high`/`low`/`normal`), or null when there is no signal.
        /// </param>
        /// <param name="flagRaw">
        /// The lab's verbatim flag.
        /// </param>
        /// <param name="appliedRange">
        /// Bounds of the reference range the flag was judged against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportInterpretation(
            string source,
            string? flag,
            string? flagRaw,
            global::Terra.LabReportAppliedRange? appliedRange)
        {
            this.Flag = flag;
            this.FlagRaw = flagRaw;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.AppliedRange = appliedRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportInterpretation" /> class.
        /// </summary>
        public LabReportInterpretation()
        {
        }

    }
}