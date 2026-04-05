
#nullable enable

namespace Terra
{
    /// <summary>
    /// Permission change event
    /// </summary>
    public sealed partial class PermissionChangeEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PermissionChangeEventTypeJsonConverter))]
        public global::Terra.PermissionChangeEventType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PermissionChangeEventStatusJsonConverter))]
        public global::Terra.PermissionChangeEventStatus Status { get; set; }

        /// <summary>
        /// Information about the permission change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// API version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Newly added scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScopesAdded { get; set; }

        /// <summary>
        /// Removed scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes_removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScopesRemoved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionChangeEvent" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message">
        /// Information about the permission change
        /// </param>
        /// <param name="version">
        /// API version
        /// </param>
        /// <param name="scopesAdded">
        /// Newly added scopes
        /// </param>
        /// <param name="scopesRemoved">
        /// Removed scopes
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// Status of the event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionChangeEvent(
            global::Terra.TerraUser user,
            string message,
            string version,
            string scopesAdded,
            string scopesRemoved,
            global::Terra.PermissionChangeEventType type,
            global::Terra.PermissionChangeEventStatus status)
        {
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.ScopesAdded = scopesAdded ?? throw new global::System.ArgumentNullException(nameof(scopesAdded));
            this.ScopesRemoved = scopesRemoved ?? throw new global::System.ArgumentNullException(nameof(scopesRemoved));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionChangeEvent" /> class.
        /// </summary>
        public PermissionChangeEvent()
        {
        }
    }
}