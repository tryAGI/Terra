
#nullable enable

namespace Terra
{
    /// <summary>
    /// Large request processing event
    /// </summary>
    public sealed partial class LargeRequestProcessingEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.LargeRequestProcessingEventTypeJsonConverter))]
        public global::Terra.LargeRequestProcessingEventType Type { get; set; }

        /// <summary>
        /// Status of the processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.LargeRequestProcessingEventStatusJsonConverter))]
        public global::Terra.LargeRequestProcessingEventStatus Status { get; set; }

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
        /// Reference ID for tracking this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LargeRequestProcessingEvent" /> class.
        /// </summary>
        /// <param name="message">
        /// Information about the processing
        /// </param>
        /// <param name="user"></param>
        /// <param name="reference">
        /// Reference ID for tracking this request
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of the processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LargeRequestProcessingEvent(
            string message,
            global::Terra.TerraUser user,
            string reference,
            global::Terra.LargeRequestProcessingEventType type,
            global::Terra.LargeRequestProcessingEventStatus status)
        {
            this.Type = type;
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LargeRequestProcessingEvent" /> class.
        /// </summary>
        public LargeRequestProcessingEvent()
        {
        }
    }
}