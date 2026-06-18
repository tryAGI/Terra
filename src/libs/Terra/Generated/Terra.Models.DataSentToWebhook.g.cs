
#nullable enable

namespace Terra
{
    /// <summary>
    /// Acknowledgement returned when `to_webhook` is true (the default): the requested data is fetched asynchronously and delivered to your configured destination, and this body confirms the request was accepted.
    /// </summary>
    public sealed partial class DataSentToWebhook
    {
        /// <summary>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.DataSentToWebhookStatusJsonConverter))]
        public global::Terra.DataSentToWebhookStatus? Status { get; set; }

        /// <summary>
        /// The data type that was requested (e.g. `activity`, `sleep`).<br/>
        /// Example: activity
        /// </summary>
        /// <example>activity</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Payload reference, tying this request to the webhook payload you will receive.<br/>
        /// Example: 5a3c2540-7139-44c6-8158-f81196e2cf2e
        /// </summary>
        /// <example>5a3c2540-7139-44c6-8158-f81196e2cf2e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// Trace identifier for this request (equal to `reference`).<br/>
        /// Example: 5a3c2540-7139-44c6-8158-f81196e2cf2e
        /// </summary>
        /// <example>5a3c2540-7139-44c6-8158-f81196e2cf2e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Present only for large requests (date range over one month), which are delivered in chunks.<br/>
        /// Example: Large request submitted. The data is being processed and will be sent to your destination in chunks
        /// </summary>
        /// <example>Large request submitted. The data is being processed and will be sent to your destination in chunks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Summary of the connection the data was requested for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Terra.DataSentToWebhookUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSentToWebhook" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: success
        /// </param>
        /// <param name="type">
        /// The data type that was requested (e.g. `activity`, `sleep`).<br/>
        /// Example: activity
        /// </param>
        /// <param name="reference">
        /// Payload reference, tying this request to the webhook payload you will receive.<br/>
        /// Example: 5a3c2540-7139-44c6-8158-f81196e2cf2e
        /// </param>
        /// <param name="traceId">
        /// Trace identifier for this request (equal to `reference`).<br/>
        /// Example: 5a3c2540-7139-44c6-8158-f81196e2cf2e
        /// </param>
        /// <param name="message">
        /// Present only for large requests (date range over one month), which are delivered in chunks.<br/>
        /// Example: Large request submitted. The data is being processed and will be sent to your destination in chunks
        /// </param>
        /// <param name="user">
        /// Summary of the connection the data was requested for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSentToWebhook(
            global::Terra.DataSentToWebhookStatus? status,
            string? type,
            string? reference,
            string? traceId,
            string? message,
            global::Terra.DataSentToWebhookUser? user)
        {
            this.Status = status;
            this.Type = type;
            this.Reference = reference;
            this.TraceId = traceId;
            this.Message = message;
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