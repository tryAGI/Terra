
#nullable enable

namespace Terra
{
    /// <summary>
    /// Structured failure reason. retriable tells you whether re-submitting the same input could succeed (a transient internal fault) or the input must change first (e.g. an unreadable file).
    /// </summary>
    public sealed partial class LabReportEventError
    {
        /// <summary>
        /// Finite code: file_unreadable, extraction_failed, standardization_failed, internal.<br/>
        /// Example: extraction_failed
        /// </summary>
        /// <example>extraction_failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retriable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Retriable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventError" /> class.
        /// </summary>
        /// <param name="code">
        /// Finite code: file_unreadable, extraction_failed, standardization_failed, internal.<br/>
        /// Example: extraction_failed
        /// </param>
        /// <param name="message"></param>
        /// <param name="retriable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportEventError(
            string code,
            string message,
            bool retriable)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Retriable = retriable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventError" /> class.
        /// </summary>
        public LabReportEventError()
        {
        }

    }
}