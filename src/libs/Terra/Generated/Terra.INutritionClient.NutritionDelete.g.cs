#nullable enable

namespace Terra
{
    public partial interface INutritionClient
    {
        /// <summary>
        /// Delete nutrition logs for a given user ID<br/>
        /// Used to delete nutrition logs the user has registered on their account
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.NutritionDeleteResponse> NutritionDeleteAsync(
            string userId,

            global::Terra.NutritionDeleteRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete nutrition logs for a given user ID<br/>
        /// Used to delete nutrition logs the user has registered on their account
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="data">
        /// List of identifiers for nutrition entries to be deleted
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.NutritionDeleteResponse> NutritionDeleteAsync(
            string userId,
            global::System.Collections.Generic.IList<string>? data = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}