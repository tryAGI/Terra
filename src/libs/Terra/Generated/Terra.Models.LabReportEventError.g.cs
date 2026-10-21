
#nullable enable

namespace Terra
{
    /// <summary>
    /// Structured failure reason, on the lab_report.failed webhook and on a failed session.
    /// </summary>
    public sealed partial class LabReportEventError
    {
        /// <summary>
        /// Machine-readable failure code. An open set: handle codes you do not recognise like internal. unsupported_report_type: the file is not a lab report or DXA scan (see document_class). file_unreadable: the file could not be read, e.g. a blurry or cropped photo, or an image that does not decode; ask the user for a clearer one. file_too_large: the files together exceed what one report can be read from; upload fewer or smaller files. no_results_found: the report was readable but has no results in it. extraction_failed: the results could not be extracted from the file. standardization_failed: the extracted results could not be standardized. internal: a fault on our side.<br/>
        /// Example: unsupported_report_type
        /// </summary>
        /// <example>unsupported_report_type</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable explanation. Not stable; branch on code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Whether POST …/reprocess may succeed with no change to the input. False means the input must change first: upload a different file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retriable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Retriable { get; set; }

        /// <summary>
        /// For unsupported_report_type only: what the file was judged to be instead of a lab report or scan. other_medical (another medical document, e.g. a DNA test or an imaging report) or non_medical. An open set.<br/>
        /// Example: other_medical
        /// </summary>
        /// <example>other_medical</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_class")]
        public string? DocumentClass { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventError" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable failure code. An open set: handle codes you do not recognise like internal. unsupported_report_type: the file is not a lab report or DXA scan (see document_class). file_unreadable: the file could not be read, e.g. a blurry or cropped photo, or an image that does not decode; ask the user for a clearer one. file_too_large: the files together exceed what one report can be read from; upload fewer or smaller files. no_results_found: the report was readable but has no results in it. extraction_failed: the results could not be extracted from the file. standardization_failed: the extracted results could not be standardized. internal: a fault on our side.<br/>
        /// Example: unsupported_report_type
        /// </param>
        /// <param name="message">
        /// Human-readable explanation. Not stable; branch on code.
        /// </param>
        /// <param name="retriable">
        /// Whether POST …/reprocess may succeed with no change to the input. False means the input must change first: upload a different file.
        /// </param>
        /// <param name="documentClass">
        /// For unsupported_report_type only: what the file was judged to be instead of a lab report or scan. other_medical (another medical document, e.g. a DNA test or an imaging report) or non_medical. An open set.<br/>
        /// Example: other_medical
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportEventError(
            string code,
            string message,
            bool retriable,
            string? documentClass)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Retriable = retriable;
            this.DocumentClass = documentClass;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventError" /> class.
        /// </summary>
        public LabReportEventError()
        {
        }

    }
}