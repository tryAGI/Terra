
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFile" /> class.
        /// </summary>
        /// <param name="presignedUrl"></param>
        /// <param name="filename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportFile(
            string presignedUrl,
            string? filename)
        {
            this.Filename = filename;
            this.PresignedUrl = presignedUrl ?? throw new global::System.ArgumentNullException(nameof(presignedUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFile" /> class.
        /// </summary>
        public LabReportFile()
        {
        }

    }
}