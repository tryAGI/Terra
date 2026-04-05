
#nullable enable

namespace Terra
{
    /// <summary>
    /// Processing event returned when data is being fetched asynchronously
    /// </summary>
    public sealed partial class ProcessingEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.ProcessingEventTypeJsonConverter))]
        public global::Terra.ProcessingEventType Type { get; set; }

        /// <summary>
        /// Status of the processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.ProcessingEventStatusJsonConverter))]
        public global::Terra.ProcessingEventStatus Status { get; set; }

        /// <summary>
        /// Information about the processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// Seconds to wait before retrying
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_after_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RetryAfterSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingEvent" /> class.
        /// </summary>
        /// <param name="message">
        /// Information about the processing
        /// </param>
        /// <param name="user"></param>
        /// <param name="retryAfterSeconds">
        /// Seconds to wait before retrying
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of the processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessingEvent(
            string message,
            global::Terra.TerraUser user,
            int retryAfterSeconds,
            global::Terra.ProcessingEventType type,
            global::Terra.ProcessingEventStatus status)
        {
            this.Type = type;
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.RetryAfterSeconds = retryAfterSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingEvent" /> class.
        /// </summary>
        public ProcessingEvent()
        {
        }
    }
}