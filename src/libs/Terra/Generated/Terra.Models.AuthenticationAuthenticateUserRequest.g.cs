
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthenticationAuthenticateUserRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_success_redirect_url")]
        public string? AuthSuccessRedirectUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_failure_redirect_url")]
        public string? AuthFailureRedirectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationAuthenticateUserRequest" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="referenceId"></param>
        /// <param name="authSuccessRedirectUrl"></param>
        /// <param name="authFailureRedirectUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationAuthenticateUserRequest(
            string? language,
            string? referenceId,
            string? authSuccessRedirectUrl,
            string? authFailureRedirectUrl)
        {
            this.Language = language;
            this.ReferenceId = referenceId;
            this.AuthSuccessRedirectUrl = authSuccessRedirectUrl;
            this.AuthFailureRedirectUrl = authFailureRedirectUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationAuthenticateUserRequest" /> class.
        /// </summary>
        public AuthenticationAuthenticateUserRequest()
        {
        }
    }
}