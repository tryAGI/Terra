
#nullable enable

namespace Terra
{
    /// <summary>
    /// User re-authentication event
    /// </summary>
    public sealed partial class UserReauthEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.UserReauthEventTypeJsonConverter))]
        public global::Terra.UserReauthEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser NewUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser OldUser { get; set; }

        /// <summary>
        /// Status of the re-authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.UserReauthEventStatusJsonConverter))]
        public global::Terra.UserReauthEventStatus Status { get; set; }

        /// <summary>
        /// Information about the re-authentication
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
        /// Initializes a new instance of the <see cref="UserReauthEvent" /> class.
        /// </summary>
        /// <param name="newUser"></param>
        /// <param name="oldUser"></param>
        /// <param name="message">
        /// Information about the re-authentication
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of the re-authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserReauthEvent(
            global::Terra.TerraUser newUser,
            global::Terra.TerraUser oldUser,
            string message,
            global::Terra.UserReauthEventType type,
            global::Terra.UserReauthEventStatus status)
        {
            this.Type = type;
            this.NewUser = newUser ?? throw new global::System.ArgumentNullException(nameof(newUser));
            this.OldUser = oldUser ?? throw new global::System.ArgumentNullException(nameof(oldUser));
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserReauthEvent" /> class.
        /// </summary>
        public UserReauthEvent()
        {
        }
    }
}