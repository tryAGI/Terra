#nullable enable

namespace Terra
{
    public partial interface INutritionClient
    {
        /// <summary>
        /// Retrieve nutrition log data for a given user ID<br/>
        /// Fetches nutrition log data such as meal type, calories, macronutrients etc. for a given user ID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="toWebhook"></param>
        /// <param name="withSamples"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.NutritionFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>> NutritionFetchAsync(
            string userId,
            global::Terra.OneOf<int?, global::System.DateTime?> startDate,
            global::Terra.OneOf<int?, global::System.DateTime?>? endDate = default,
            bool? toWebhook = default,
            bool? withSamples = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}