#nullable enable

namespace Terra
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Generate an authentication link<br/>
        /// Creates a login link that allows end users to connect their fitness tracking account
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AuthenticationAuthenticateUserResponse> AuthenticationAuthenticateUserAsync(
            string resource,

            global::Terra.AuthenticationAuthenticateUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an authentication link<br/>
        /// Creates a login link that allows end users to connect their fitness tracking account
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="language"></param>
        /// <param name="referenceId"></param>
        /// <param name="authSuccessRedirectUrl"></param>
        /// <param name="authFailureRedirectUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AuthenticationAuthenticateUserResponse> AuthenticationAuthenticateUserAsync(
            string resource,
            string? language = default,
            string? referenceId = default,
            string? authSuccessRedirectUrl = default,
            string? authFailureRedirectUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}