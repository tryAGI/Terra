
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TerraUser
    {
        /// <summary>
        /// Terra identifier for the wearable connection<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Connection data source<br/>
        /// Example: FITBIT
        /// </summary>
        /// <example>FITBIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Last time at which a webhook update was sent for the connection<br/>
        /// Example: 2022-12-12T10:00:00.000000+00:00
        /// </summary>
        /// <example>2022-12-12T10:00:00.000000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_webhook_update")]
        public string? LastWebhookUpdate { get; set; }

        /// <summary>
        /// (when available) Permissions granted by the user during authentication - to be used as debugging metadata<br/>
        /// Example: activity:read,sleep:read
        /// </summary>
        /// <example>activity:read,sleep:read</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public string? Scopes { get; set; }

        /// <summary>
        /// Connection identifier on the developer's end, used to tie connection back to a user on the developer's platform<br/>
        /// Example: user123@email.com
        /// </summary>
        /// <example>user123@email.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// whether the user is active or not (inactive users will not receive any data updates and are in considered <br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TerraUser" /> class.
        /// </summary>
        /// <param name="userId">
        /// Terra identifier for the wearable connection<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="provider">
        /// Connection data source<br/>
        /// Example: FITBIT
        /// </param>
        /// <param name="lastWebhookUpdate">
        /// Last time at which a webhook update was sent for the connection<br/>
        /// Example: 2022-12-12T10:00:00.000000+00:00
        /// </param>
        /// <param name="scopes">
        /// (when available) Permissions granted by the user during authentication - to be used as debugging metadata<br/>
        /// Example: activity:read,sleep:read
        /// </param>
        /// <param name="referenceId">
        /// Connection identifier on the developer's end, used to tie connection back to a user on the developer's platform<br/>
        /// Example: user123@email.com
        /// </param>
        /// <param name="active">
        /// whether the user is active or not (inactive users will not receive any data updates and are in considered <br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TerraUser(
            string userId,
            string provider,
            string? lastWebhookUpdate,
            string? scopes,
            string? referenceId,
            bool? active)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.LastWebhookUpdate = lastWebhookUpdate;
            this.Scopes = scopes;
            this.ReferenceId = referenceId;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerraUser" /> class.
        /// </summary>
        public TerraUser()
        {
        }
    }
}