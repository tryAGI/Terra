
#nullable enable

namespace Terra
{
    /// <summary>
    /// Summary of the connection the data was requested for.
    /// </summary>
    public sealed partial class DataSentToWebhookUser
    {
        /// <summary>
        /// Example: 5a3c2540-7139-44c6-8158-f81196e2cf2e
        /// </summary>
        /// <example>5a3c2540-7139-44c6-8158-f81196e2cf2e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Example: GARMIN
        /// </summary>
        /// <example>GARMIN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Example: user123@email.com
        /// </summary>
        /// <example>user123@email.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// Example: 2024-01-15T09:30:00Z
        /// </summary>
        /// <example>2024-01-15T09:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Comma-separated list of granted scopes.<br/>
        /// Example: activity,sleep,daily
        /// </summary>
        /// <example>activity,sleep,daily</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public string? Scopes { get; set; }

        /// <summary>
        /// Example: 2024-01-20T11:00:00Z
        /// </summary>
        /// <example>2024-01-20T11:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_webhook_update")]
        public global::System.DateTime? LastWebhookUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSentToWebhookUser" /> class.
        /// </summary>
        /// <param name="userId">
        /// Example: 5a3c2540-7139-44c6-8158-f81196e2cf2e
        /// </param>
        /// <param name="provider">
        /// Example: GARMIN
        /// </param>
        /// <param name="referenceId">
        /// Example: user123@email.com
        /// </param>
        /// <param name="createdAt">
        /// Example: 2024-01-15T09:30:00Z
        /// </param>
        /// <param name="active">
        /// Example: true
        /// </param>
        /// <param name="scopes">
        /// Comma-separated list of granted scopes.<br/>
        /// Example: activity,sleep,daily
        /// </param>
        /// <param name="lastWebhookUpdate">
        /// Example: 2024-01-20T11:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSentToWebhookUser(
            string? userId,
            string? provider,
            string? referenceId,
            global::System.DateTime? createdAt,
            bool? active,
            string? scopes,
            global::System.DateTime? lastWebhookUpdate)
        {
            this.UserId = userId;
            this.Provider = provider;
            this.ReferenceId = referenceId;
            this.CreatedAt = createdAt;
            this.Active = active;
            this.Scopes = scopes;
            this.LastWebhookUpdate = lastWebhookUpdate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSentToWebhookUser" /> class.
        /// </summary>
        public DataSentToWebhookUser()
        {
        }

    }
}