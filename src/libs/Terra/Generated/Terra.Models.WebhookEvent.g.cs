
#nullable enable

namespace Terra
{
    /// <summary>
    /// Base webhook event structure that all events extend from
    /// </summary>
    public sealed partial class WebhookEvent
    {
        /// <summary>
        /// The type of event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Status of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event
        /// </param>
        /// <param name="status">
        /// Status of the event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEvent(
            string type,
            string? status)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEvent" /> class.
        /// </summary>
        public WebhookEvent()
        {
        }
    }
}