
#nullable enable

namespace Terra
{
    /// <summary>
    /// Healthcheck event sent periodically to verify your webhook endpoint is functional
    /// </summary>
    public sealed partial class HealthcheckEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.HealthcheckEventTypeJsonConverter))]
        public global::Terra.HealthcheckEventType Type { get; set; }

        /// <summary>
        /// Status of the healthcheck
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Timestamp when the event was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreationTimestamp { get; set; }

        /// <summary>
        /// Percentage change in trends
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trend_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrendPercentage { get; set; }

        /// <summary>
        /// Number of webhooks sent in the last hour
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent_webhooks_last_hour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentWebhooksLastHour { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthcheckEvent" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the healthcheck
        /// </param>
        /// <param name="creationTimestamp">
        /// Timestamp when the event was created
        /// </param>
        /// <param name="trendPercentage">
        /// Percentage change in trends
        /// </param>
        /// <param name="sentWebhooksLastHour">
        /// Number of webhooks sent in the last hour
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HealthcheckEvent(
            string status,
            string creationTimestamp,
            int trendPercentage,
            int sentWebhooksLastHour,
            global::Terra.HealthcheckEventType type)
        {
            this.Type = type;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreationTimestamp = creationTimestamp ?? throw new global::System.ArgumentNullException(nameof(creationTimestamp));
            this.TrendPercentage = trendPercentage;
            this.SentWebhooksLastHour = sentWebhooksLastHour;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthcheckEvent" /> class.
        /// </summary>
        public HealthcheckEvent()
        {
        }
    }
}