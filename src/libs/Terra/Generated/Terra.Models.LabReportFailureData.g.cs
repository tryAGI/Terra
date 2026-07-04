
#nullable enable

namespace Terra
{
    /// <summary>
    /// The failed lab report resource.
    /// </summary>
    public sealed partial class LabReportFailureData
    {
        /// <summary>
        /// Example: 297405620317847552
        /// </summary>
        /// <example>297405620317847552</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Your external reference; omitted if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// Structured failure reason. retriable tells you whether re-submitting the same input could succeed (a transient internal fault) or the input must change first (e.g. an unreadable file).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.LabReportEventError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFailureData" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Example: 297405620317847552
        /// </param>
        /// <param name="error">
        /// Structured failure reason. retriable tells you whether re-submitting the same input could succeed (a transient internal fault) or the input must change first (e.g. an unreadable file).
        /// </param>
        /// <param name="referenceId">
        /// Your external reference; omitted if not set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportFailureData(
            string sessionId,
            global::Terra.LabReportEventError error,
            string? referenceId)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.ReferenceId = referenceId;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFailureData" /> class.
        /// </summary>
        public LabReportFailureData()
        {
        }

    }
}