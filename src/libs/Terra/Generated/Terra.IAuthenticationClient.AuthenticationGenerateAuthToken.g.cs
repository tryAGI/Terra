#nullable enable

namespace Terra
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Generates an authentication token for the Terra mobile SDKs<br/>
        /// Creates a token to be used with initConnection() functions in the Terra mobile SDKs in order to create a user record for Apple Health or Samsung Health (or equivalent)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AuthenticationGenerateAuthTokenResponse> AuthenticationGenerateAuthTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}