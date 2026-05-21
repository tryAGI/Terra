
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Connection
    {
        /// <summary>
        /// Terra connection ID.<br/>
        /// Example: 75001
        /// </summary>
        /// <example>75001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// External user identifier provided at connect time.<br/>
        /// Example: user_external_ref_123
        /// </summary>
        /// <example>user_external_ref_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// RFC3339 timestamp of when the connection was first authorised.<br/>
        /// Example: 2026-04-22T11:00:00Z
        /// </summary>
        /// <example>2026-04-22T11:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Uppercase provider slug, e.g. MIRA or FITBIT.<br/>
        /// Example: MIRA
        /// </summary>
        /// <example>MIRA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// RFC3339 timestamp of the last poll Terra ran against the provider for this connection. May be null for webhook-only flows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_polled_at")]
        public string? LastPolledAt { get; set; }

        /// <summary>
        /// RFC3339 timestamp of the last time Terra received any data from the provider for this connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public string? LastUpdatedAt { get; set; }

        /// <summary>
        /// RFC3339 timestamp of the most recent stored sample. May lag last_updated_at when fetches return no new data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_data_at")]
        public string? MostRecentDataAt { get; set; }

        /// <summary>
        /// Granted OAuth scopes. Empty array for providers without scopes (e.g. Mira).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="id">
        /// Terra connection ID.<br/>
        /// Example: 75001
        /// </param>
        /// <param name="createdAt">
        /// RFC3339 timestamp of when the connection was first authorised.<br/>
        /// Example: 2026-04-22T11:00:00Z
        /// </param>
        /// <param name="provider">
        /// Uppercase provider slug, e.g. MIRA or FITBIT.<br/>
        /// Example: MIRA
        /// </param>
        /// <param name="scopes">
        /// Granted OAuth scopes. Empty array for providers without scopes (e.g. Mira).
        /// </param>
        /// <param name="referenceId">
        /// External user identifier provided at connect time.<br/>
        /// Example: user_external_ref_123
        /// </param>
        /// <param name="lastPolledAt">
        /// RFC3339 timestamp of the last poll Terra ran against the provider for this connection. May be null for webhook-only flows.
        /// </param>
        /// <param name="lastUpdatedAt">
        /// RFC3339 timestamp of the last time Terra received any data from the provider for this connection.
        /// </param>
        /// <param name="mostRecentDataAt">
        /// RFC3339 timestamp of the most recent stored sample. May lag last_updated_at when fetches return no new data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Connection(
            int id,
            string createdAt,
            string provider,
            global::System.Collections.Generic.IList<string> scopes,
            string? referenceId,
            string? lastPolledAt,
            string? lastUpdatedAt,
            string? mostRecentDataAt)
        {
            this.Id = id;
            this.ReferenceId = referenceId;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.LastPolledAt = lastPolledAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.MostRecentDataAt = mostRecentDataAt;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        public Connection()
        {
        }

    }
}