
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthenticationCreateAuthTokenResponse
    {
        /// <summary>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: 250c68b9c21b78e40e7a3285a2d538d3bc24aabd3b4c76a782fb0a571ca4501d
        /// </summary>
        /// <example>250c68b9c21b78e40e7a3285a2d538d3bc24aabd3b4c76a782fb0a571ca4501d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Default Value: 0<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationCreateAuthTokenResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: success
        /// </param>
        /// <param name="token">
        /// Example: 250c68b9c21b78e40e7a3285a2d538d3bc24aabd3b4c76a782fb0a571ca4501d
        /// </param>
        /// <param name="expiresIn">
        /// Default Value: 0<br/>
        /// Example: 180
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationCreateAuthTokenResponse(
            string? status,
            string? token,
            int? expiresIn)
        {
            this.Status = status;
            this.Token = token;
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationCreateAuthTokenResponse" /> class.
        /// </summary>
        public AuthenticationCreateAuthTokenResponse()
        {
        }

    }
}