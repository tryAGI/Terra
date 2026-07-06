#nullable enable

namespace Terra
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get info for multiple users<br/>
        /// Returns the Terra users for a batch of user IDs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Terra.TerraUser>> UserBatchGetAsync(

            global::System.Collections.Generic.IList<string> request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get info for multiple users<br/>
        /// Returns the Terra users for a batch of user IDs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Terra.TerraUser>>> UserBatchGetAsResponseAsync(

            global::System.Collections.Generic.IList<string> request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}