
#nullable enable

namespace Terra
{
    /// <summary>
    /// S3 Upload event with data download URL
    /// </summary>
    public sealed partial class S3PayloadEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.S3PayloadEventTypeJsonConverter))]
        public global::Terra.S3PayloadEventType Type { get; set; }

        /// <summary>
        /// Status of the upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.S3PayloadEventStatusJsonConverter))]
        public global::Terra.S3PayloadEventStatus Status { get; set; }

        /// <summary>
        /// URL to download the data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Time in seconds until URL expiration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="S3PayloadEvent" /> class.
        /// </summary>
        /// <param name="url">
        /// URL to download the data
        /// </param>
        /// <param name="expiresIn">
        /// Time in seconds until URL expiration
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of the upload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public S3PayloadEvent(
            string url,
            int expiresIn,
            global::Terra.S3PayloadEventType type,
            global::Terra.S3PayloadEventStatus status)
        {
            this.Type = type;
            this.Status = status;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3PayloadEvent" /> class.
        /// </summary>
        public S3PayloadEvent()
        {
        }
    }
}