
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
        /// The old user record that will be deleted, when available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_user")]
        public global::Terra.TerraUser? OldUser { get; set; }

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
        /// Payload schema version<br/>
        /// Example: 2022-03-16
        /// </summary>
        /// <example>2022-03-16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserReauthEvent" /> class.
        /// </summary>
        /// <param name="newUser"></param>
        /// <param name="message">
        /// Information about the re-authentication
        /// </param>
        /// <param name="type"></param>
        /// <param name="oldUser">
        /// The old user record that will be deleted, when available
        /// </param>
        /// <param name="status">
        /// Status of the re-authentication
        /// </param>
        /// <param name="version">
        /// Payload schema version<br/>
        /// Example: 2022-03-16
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserReauthEvent(
            global::Terra.TerraUser newUser,
            string message,
            global::Terra.UserReauthEventType type,
            global::Terra.TerraUser? oldUser,
            global::Terra.UserReauthEventStatus status,
            string? version)
        {
            this.Type = type;
            this.NewUser = newUser ?? throw new global::System.ArgumentNullException(nameof(newUser));
            this.OldUser = oldUser;
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserReauthEvent" /> class.
        /// </summary>
        public UserReauthEvent()
        {
        }

    }
}