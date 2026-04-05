#nullable enable

namespace Terra
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Deauthenticates a user and deletes any cached data for them<br/>
        /// Deletes all records of the user on Terra's end, revoking Terra's access to their data
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AuthenticationDeauthenticateUserResponse> AuthenticationDeauthenticateUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}