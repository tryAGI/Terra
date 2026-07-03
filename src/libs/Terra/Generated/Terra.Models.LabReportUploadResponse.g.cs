
#nullable enable

namespace Terra
{
    /// <summary>
    /// Returned by the upload endpoint. A single upload may fan out to multiple sessions.
    /// </summary>
    public sealed partial class LabReportUploadResponse
    {
        /// <summary>
        /// Durable correlation key for the upload; every resulting session and webhook carries it.<br/>
        /// Example: upl_4a2b8c1d
        /// </summary>
        /// <example>upl_4a2b8c1d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadId { get; set; }

        /// <summary>
        /// Processing status as a clean lowercase string.<br/>
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
        /// Initializes a new instance of the <see cref="LabReportUploadResponse" /> class.
        /// </summary>
        /// <param name="uploadId">
        /// Durable correlation key for the upload; every resulting session and webhook carries it.<br/>
        /// Example: upl_4a2b8c1d
        /// </param>
        /// <param name="currentStatus">
        /// Processing status as a clean lowercase string.<br/>
        /// Example: processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportUploadResponse(
            string uploadId,
            string currentStatus)
        {
            this.UploadId = uploadId ?? throw new global::System.ArgumentNullException(nameof(uploadId));
            this.CurrentStatus = currentStatus ?? throw new global::System.ArgumentNullException(nameof(currentStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportUploadResponse" /> class.
        /// </summary>
        public LabReportUploadResponse()
        {
        }

    }
}