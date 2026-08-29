
#nullable enable

namespace Terra
{
    /// <summary>
    /// Authentication success event
    /// </summary>
    public sealed partial class AuthSuccessEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AuthSuccessEventTypeJsonConverter))]
        public global::Terra.AuthSuccessEventType Type { get; set; }

        /// <summary>
        /// Status of authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AuthSuccessEventStatusJsonConverter))]
        public global::Terra.AuthSuccessEventStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// Human-readable confirmation message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Identifier of the authentication flow that completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flow_id")]
        public string? FlowId { get; set; }

        /// <summary>
        /// Widget session identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget_session_id")]
        public string? WidgetSessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSuccessEvent" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of authentication
        /// </param>
        /// <param name="message">
        /// Human-readable confirmation message
        /// </param>
        /// <param name="flowId">
        /// Identifier of the authentication flow that completed
        /// </param>
        /// <param name="widgetSessionId">
        /// Widget session identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthSuccessEvent(
            global::Terra.TerraUser user,
            global::Terra.AuthSuccessEventType type,
            global::Terra.AuthSuccessEventStatus status,
            string? message,
            string? flowId,
            string? widgetSessionId)
        {
            this.Type = type;
            this.Status = status;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Message = message;
            this.FlowId = flowId;
            this.WidgetSessionId = widgetSessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSuccessEvent" /> class.
        /// </summary>
        public AuthSuccessEvent()
        {
        }

    }
}