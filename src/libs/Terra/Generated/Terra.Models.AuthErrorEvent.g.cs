
#nullable enable

namespace Terra
{
    /// <summary>
    /// Authentication error event, sent when an authentication flow fails or is cancelled
    /// </summary>
    public sealed partial class AuthErrorEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AuthErrorEventTypeJsonConverter))]
        public global::Terra.AuthErrorEventType Type { get; set; }

        /// <summary>
        /// Status of authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AuthErrorEventStatusJsonConverter))]
        public global::Terra.AuthErrorEventStatus Status { get; set; }

        /// <summary>
        /// Identifier of the authentication flow that failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flow_id")]
        public string? FlowId { get; set; }

        /// <summary>
        /// Reason for the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Client-provided reference ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthErrorEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of authentication
        /// </param>
        /// <param name="flowId">
        /// Identifier of the authentication flow that failed
        /// </param>
        /// <param name="reason">
        /// Reason for the error
        /// </param>
        /// <param name="referenceId">
        /// Client-provided reference ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthErrorEvent(
            global::Terra.AuthErrorEventType type,
            global::Terra.AuthErrorEventStatus status,
            string? flowId,
            string? reason,
            string? referenceId)
        {
            this.Type = type;
            this.Status = status;
            this.FlowId = flowId;
            this.Reason = reason;
            this.ReferenceId = referenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthErrorEvent" /> class.
        /// </summary>
        public AuthErrorEvent()
        {
        }

    }
}