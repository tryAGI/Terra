#nullable enable

namespace Terra
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Modify user<br/>
        /// Update a Terra user's reference_id or active status
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.UserModifyUserResponse> UserModifyUserAsync(
            string userId,

            global::Terra.UserModifyUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify user<br/>
        /// Update a Terra user's reference_id or active status
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="referenceId">
        /// Identifier on your system to associate with this user<br/>
        /// Example: updatedUser123
        /// </param>
        /// <param name="active">
        /// Whether the user should remain active
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.UserModifyUserResponse> UserModifyUserAsync(
            string userId,
            string? referenceId = default,
            bool? active = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}