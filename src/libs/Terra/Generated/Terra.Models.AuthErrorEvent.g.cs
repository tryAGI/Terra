
#nullable enable

namespace Terra
{
    /// <summary>
    /// Authentication error event
    /// </summary>
    public sealed partial class AuthErrorEvent
    {
        /// <summary>
        /// Status of authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AuthErrorEventStatusJsonConverter))]
        public global::Terra.AuthErrorEventStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// Provider information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Reason for the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Client-provided reference ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceId { get; set; }

        /// <summary>
        /// Widget session identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget_session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WidgetSessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthErrorEvent" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="provider">
        /// Provider information
        /// </param>
        /// <param name="message">
        /// Error message
        /// </param>
        /// <param name="reason">
        /// Reason for the error
        /// </param>
        /// <param name="referenceId">
        /// Client-provided reference ID
        /// </param>
        /// <param name="widgetSessionId">
        /// Widget session identifier
        /// </param>
        /// <param name="status">
        /// Status of authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthErrorEvent(
            global::Terra.TerraUser user,
            string provider,
            string message,
            string reason,
            string referenceId,
            string widgetSessionId,
            global::Terra.AuthErrorEventStatus status)
        {
            this.Status = status;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.ReferenceId = referenceId ?? throw new global::System.ArgumentNullException(nameof(referenceId));
            this.WidgetSessionId = widgetSessionId ?? throw new global::System.ArgumentNullException(nameof(widgetSessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthErrorEvent" /> class.
        /// </summary>
        public AuthErrorEvent()
        {
        }
    }
}