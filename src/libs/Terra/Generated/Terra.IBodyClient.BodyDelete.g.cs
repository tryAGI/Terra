#nullable enable

namespace Terra
{
    public partial interface IBodyClient
    {
        /// <summary>
        /// Delete body metrics for a given user ID<br/>
        /// Used to delete Body metrics the user has registered on their account
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.BodyDeleteResponse> BodyDeleteAsync(
            string userId,

            global::Terra.BodyDeleteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete body metrics for a given user ID<br/>
        /// Used to delete Body metrics the user has registered on their account
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="logIds">
        /// List of identifiers for body metrics entries to be deleted
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.BodyDeleteResponse> BodyDeleteAsync(
            string userId,
            global::System.Collections.Generic.IList<string>? logIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}