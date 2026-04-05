
#nullable enable

namespace Terra
{
    /// <summary>
    /// Connection error event
    /// </summary>
    public sealed partial class ConnectionErrorEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.ConnectionErrorEventTypeJsonConverter))]
        public global::Terra.ConnectionErrorEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// Status of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.ConnectionErrorEventStatusJsonConverter))]
        public global::Terra.ConnectionErrorEventStatus Status { get; set; }

        /// <summary>
        /// Information about the connection issue
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
        /// Initializes a new instance of the <see cref="ConnectionErrorEvent" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message">
        /// Information about the connection issue
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of the event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectionErrorEvent(
            global::Terra.TerraUser user,
            string message,
            global::Terra.ConnectionErrorEventType type,
            global::Terra.ConnectionErrorEventStatus status)
        {
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionErrorEvent" /> class.
        /// </summary>
        public ConnectionErrorEvent()
        {
        }
    }
}