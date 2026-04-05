
#nullable enable

namespace Terra
{
    /// <summary>
    /// Access revoked event when a user revokes access through the provider
    /// </summary>
    public sealed partial class AccessRevokedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AccessRevokedEventTypeJsonConverter))]
        public global::Terra.AccessRevokedEventType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AccessRevokedEventStatusJsonConverter))]
        public global::Terra.AccessRevokedEventStatus Status { get; set; }

        /// <summary>
        /// Information about the access revocation
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
        /// Initializes a new instance of the <see cref="AccessRevokedEvent" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message">
        /// Information about the access revocation
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of the event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessRevokedEvent(
            global::Terra.TerraUser user,
            string message,
            global::Terra.AccessRevokedEventType type,
            global::Terra.AccessRevokedEventStatus status)
        {
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRevokedEvent" /> class.
        /// </summary>
        public AccessRevokedEvent()
        {
        }
    }
}