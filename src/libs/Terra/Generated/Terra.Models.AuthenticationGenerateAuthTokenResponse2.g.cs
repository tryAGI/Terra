
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthenticationGenerateAuthTokenResponse2
    {
        /// <summary>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: Invalid dev-id was provided
        /// </summary>
        /// <example>Invalid dev-id was provided</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationGenerateAuthTokenResponse2" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: error
        /// </param>
        /// <param name="message">
        /// Example: Invalid dev-id was provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationGenerateAuthTokenResponse2(
            string? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationGenerateAuthTokenResponse2" /> class.
        /// </summary>
        public AuthenticationGenerateAuthTokenResponse2()
        {
        }
    }
}