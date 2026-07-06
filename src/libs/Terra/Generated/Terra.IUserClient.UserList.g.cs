#nullable enable

namespace Terra
{
    public partial interface IUserClient
    {
        /// <summary>
        /// List all user IDs<br/>
        /// Returns all Terra users. Supports optional pagination via `page` and `per_page`; if `page` is omitted, every user is returned in one response for backwards compatibility.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.UserListResponseVariant1, global::Terra.UserListResponseVariant2>> UserListAsync(
            int? page = default,
            int? perPage = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all user IDs<br/>
        /// Returns all Terra users. Supports optional pagination via `page` and `per_page`; if `page` is omitted, every user is returned in one response for backwards compatibility.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.OneOf<global::Terra.UserListResponseVariant1, global::Terra.UserListResponseVariant2>>> UserListAsResponseAsync(
            int? page = default,
            int? perPage = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}