
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabReportsUploadRequest
    {
        /// <summary>
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportsUploadRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </param>
        /// <param name="filename">
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportsUploadRequest(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportsUploadRequest" /> class.
        /// </summary>
        public LabReportsUploadRequest()
        {
        }

    }
}