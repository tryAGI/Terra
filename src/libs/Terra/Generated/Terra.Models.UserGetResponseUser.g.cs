
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserGetResponseUser
    {
        /// <summary>
        /// Last time Terra polled the provider for this connection.<br/>
        /// Example: 2024-01-20T11:00:00Z
        /// </summary>
        /// <example>2024-01-20T11:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_polled_at")]
        public global::System.DateTime? LastPolledAt { get; set; }

        /// <summary>
        /// Timestamp of the most recent data point Terra holds for this connection.<br/>
        /// Example: 2024-01-19T23:00:00Z
        /// </summary>
        /// <example>2024-01-19T23:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_data_at")]
        public global::System.DateTime? MostRecentDataAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetResponseUser" /> class.
        /// </summary>
        /// <param name="lastPolledAt">
        /// Last time Terra polled the provider for this connection.<br/>
        /// Example: 2024-01-20T11:00:00Z
        /// </param>
        /// <param name="mostRecentDataAt">
        /// Timestamp of the most recent data point Terra holds for this connection.<br/>
        /// Example: 2024-01-19T23:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetResponseUser(
            global::System.DateTime? lastPolledAt,
            global::System.DateTime? mostRecentDataAt)
        {
            this.LastPolledAt = lastPolledAt;
            this.MostRecentDataAt = mostRecentDataAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetResponseUser" /> class.
        /// </summary>
        public UserGetResponseUser()
        {
        }

    }
}