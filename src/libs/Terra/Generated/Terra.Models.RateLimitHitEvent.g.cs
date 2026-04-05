
#nullable enable

namespace Terra
{
    /// <summary>
    /// Rate limit hit event
    /// </summary>
    public sealed partial class RateLimitHitEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.RateLimitHitEventTypeJsonConverter))]
        public global::Terra.RateLimitHitEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// Start date of the requested data range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDate { get; set; }

        /// <summary>
        /// End date of the requested data range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDate { get; set; }

        /// <summary>
        /// When the request will be retried
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrying_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RetryingAt { get; set; }

        /// <summary>
        /// Information about the rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitHitEvent" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="startDate">
        /// Start date of the requested data range
        /// </param>
        /// <param name="endDate">
        /// End date of the requested data range
        /// </param>
        /// <param name="retryingAt">
        /// When the request will be retried
        /// </param>
        /// <param name="message">
        /// Information about the rate limit
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitHitEvent(
            global::Terra.TerraUser user,
            string startDate,
            string endDate,
            string retryingAt,
            string message,
            global::Terra.RateLimitHitEventType type)
        {
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.StartDate = startDate ?? throw new global::System.ArgumentNullException(nameof(startDate));
            this.EndDate = endDate ?? throw new global::System.ArgumentNullException(nameof(endDate));
            this.RetryingAt = retryingAt ?? throw new global::System.ArgumentNullException(nameof(retryingAt));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitHitEvent" /> class.
        /// </summary>
        public RateLimitHitEvent()
        {
        }
    }
}