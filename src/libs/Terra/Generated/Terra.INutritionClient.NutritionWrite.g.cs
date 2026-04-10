#nullable enable

namespace Terra
{
    public partial interface INutritionClient
    {
        /// <summary>
        /// Post nutrition logs to a provider<br/>
        /// Used to post nutrition logs to a provider. This endpoint only works for users connected via Fitbit. Returns error for other providers.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.NutritionWriteResponse> NutritionWriteAsync(

            global::Terra.NutritionWriteRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post nutrition logs to a provider<br/>
        /// Used to post nutrition logs to a provider. This endpoint only works for users connected via Fitbit. Returns error for other providers.
        /// </summary>
        /// <param name="data">
        /// Nutrition entry to post to data provider
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.NutritionWriteResponse> NutritionWriteAsync(
            global::System.Collections.Generic.IList<global::Terra.Nutrition> data,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}