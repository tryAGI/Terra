#nullable enable

namespace Terra
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get user info by user ID or reference ID<br/>
        /// Returns the Terra user for a given user ID, or every user registered under a given reference ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="referenceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.UserGetResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>> UserGetAsync(
            string? userId = default,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user info by user ID or reference ID<br/>
        /// Returns the Terra user for a given user ID, or every user registered under a given reference ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="referenceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.OneOf<global::Terra.UserGetResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>>> UserGetAsResponseAsync(
            string? userId = default,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}