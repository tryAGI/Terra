
#nullable enable

namespace Terra
{
    /// <summary>
    /// One downloadable object with a presigned URL.
    /// </summary>
    public sealed partial class LabReportFile
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presigned_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresignedUrl { get; set; }

        /// <summary>
        /// An uploaded file's content type. Present on files only.<br/>
        /// Example: image/heic
        /// </summary>
        /// <example>image/heic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFile" /> class.
        /// </summary>
        /// <param name="presignedUrl"></param>
        /// <param name="filename"></param>
        /// <param name="contentType">
        /// An uploaded file's content type. Present on files only.<br/>
        /// Example: image/heic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportFile(
            string presignedUrl,
            string? filename,
            string? contentType)
        {
            this.Filename = filename;
            this.PresignedUrl = presignedUrl ?? throw new global::System.ArgumentNullException(nameof(presignedUrl));
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFile" /> class.
        /// </summary>
        public LabReportFile()
        {
        }

    }
}