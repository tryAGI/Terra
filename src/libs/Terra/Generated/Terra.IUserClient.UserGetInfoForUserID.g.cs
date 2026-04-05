#nullable enable

namespace Terra
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get information for a single user ID or multiple users by reference ID<br/>
        /// Used to query for information on one Terra user ID, or to query for all registered Terra User objects under one reference ID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="referenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.UserGetInfoForUserIDResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>> UserGetInfoForUserIDAsync(
            string? userId = default,
            string? referenceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}