
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabReportsUploadRequest
    {
        /// <summary>
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
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
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
        /// </param>
        /// <param name="filename">
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
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