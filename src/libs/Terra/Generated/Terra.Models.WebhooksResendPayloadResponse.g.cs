
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksResendPayloadResponse
    {
        /// <summary>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.WebhooksResendPayloadResponseStatusJsonConverter))]
        public global::Terra.WebhooksResendPayloadResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksResendPayloadResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksResendPayloadResponse(
            global::Terra.WebhooksResendPayloadResponseStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksResendPayloadResponse" /> class.
        /// </summary>
        public WebhooksResendPayloadResponse()
        {
        }

    }
}