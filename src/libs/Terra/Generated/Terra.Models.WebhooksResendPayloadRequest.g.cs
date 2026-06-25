
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksResendPayloadRequest
    {
        /// <summary>
        /// ID of the original webhook event to resend (the `reference` field surfaced on the original delivery).<br/>
        /// Example: 5b04b6a4-09bd-4fc4-8bbb-6c44f0a2c0ef
        /// </summary>
        /// <example>5b04b6a4-09bd-4fc4-8bbb-6c44f0a2c0ef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksResendPayloadRequest" /> class.
        /// </summary>
        /// <param name="eventId">
        /// ID of the original webhook event to resend (the `reference` field surfaced on the original delivery).<br/>
        /// Example: 5b04b6a4-09bd-4fc4-8bbb-6c44f0a2c0ef
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksResendPayloadRequest(
            string eventId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksResendPayloadRequest" /> class.
        /// </summary>
        public WebhooksResendPayloadRequest()
        {
        }

    }
}