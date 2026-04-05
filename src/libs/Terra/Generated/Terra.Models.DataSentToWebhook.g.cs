
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataSentToWebhook
    {
        /// <summary>
        /// Payload reference, tying the request to the webhook payload which will be received<br/>
        /// Example: webhook_ref_123
        /// </summary>
        /// <example>webhook_ref_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// Example: Data will be sent to webhook
        /// </summary>
        /// <example>Data will be sent to webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: webhook
        /// </summary>
        /// <example>webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Terra User object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Terra.TerraUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSentToWebhook" /> class.
        /// </summary>
        /// <param name="reference">
        /// Payload reference, tying the request to the webhook payload which will be received<br/>
        /// Example: webhook_ref_123
        /// </param>
        /// <param name="message">
        /// Example: Data will be sent to webhook
        /// </param>
        /// <param name="type">
        /// Example: webhook
        /// </param>
        /// <param name="user">
        /// Terra User object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSentToWebhook(
            string? reference,
            string? message,
            string? type,
            global::Terra.TerraUser? user)
        {
            this.Reference = reference;
            this.Message = message;
            this.Type = type;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSentToWebhook" /> class.
        /// </summary>
        public DataSentToWebhook()
        {
        }
    }
}