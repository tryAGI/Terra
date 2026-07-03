
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabReportFilesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.LabReportFile> Files { get; set; }

        /// <summary>
        /// One downloadable object with a presigned URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public global::Terra.LabReportFile? Thumbnail { get; set; }

        /// <summary>
        /// Applies to every presigned URL in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFilesResponse" /> class.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="thumbnail">
        /// One downloadable object with a presigned URL.
        /// </param>
        /// <param name="expiresAt">
        /// Applies to every presigned URL in the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportFilesResponse(
            global::System.Collections.Generic.IList<global::Terra.LabReportFile> files,
            global::Terra.LabReportFile? thumbnail,
            global::System.DateTime? expiresAt)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Thumbnail = thumbnail;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFilesResponse" /> class.
        /// </summary>
        public LabReportFilesResponse()
        {
        }

    }
}