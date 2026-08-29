
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabReportReprocessResponse
    {
        /// <summary>
        /// Example: 297405620317847552
        /// </summary>
        /// <example>297405620317847552</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Example: processing
        /// </summary>
        /// <example>processing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportReprocessResponse" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Example: 297405620317847552
        /// </param>
        /// <param name="currentStatus">
        /// Example: processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportReprocessResponse(
            string sessionId,
            string currentStatus)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.CurrentStatus = currentStatus ?? throw new global::System.ArgumentNullException(nameof(currentStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportReprocessResponse" /> class.
        /// </summary>
        public LabReportReprocessResponse()
        {
        }

    }
}