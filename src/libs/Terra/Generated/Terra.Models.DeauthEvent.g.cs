
#nullable enable

namespace Terra
{
    /// <summary>
    /// User deauthentication event
    /// </summary>
    public sealed partial class DeauthEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.DeauthEventTypeJsonConverter))]
        public global::Terra.DeauthEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// Status of deauthentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.DeauthEventStatusJsonConverter))]
        public global::Terra.DeauthEventStatus Status { get; set; }

        /// <summary>
        /// Confirmation message
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
        /// Initializes a new instance of the <see cref="DeauthEvent" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message">
        /// Confirmation message
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of deauthentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeauthEvent(
            global::Terra.TerraUser user,
            string message,
            global::Terra.DeauthEventType type,
            global::Terra.DeauthEventStatus status)
        {
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeauthEvent" /> class.
        /// </summary>
        public DeauthEvent()
        {
        }
    }
}