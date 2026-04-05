
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthenticationDeauthenticateUserResponse
    {
        /// <summary>
        /// indicates that the deauthentication was successful (value is success)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatusJsonConverter))]
        public global::Terra.AuthenticationDeauthenticateUserResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationDeauthenticateUserResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// indicates that the deauthentication was successful (value is success)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationDeauthenticateUserResponse(
            global::Terra.AuthenticationDeauthenticateUserResponseStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationDeauthenticateUserResponse" /> class.
        /// </summary>
        public AuthenticationDeauthenticateUserResponse()
        {
        }
    }
}