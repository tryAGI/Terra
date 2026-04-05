#nullable enable

namespace Terra
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Retrieve activity data for a given user ID<br/>
        /// Fetches completed workout sessions, with a defined start and end time and activity type (e.g. running, cycling, etc.)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="toWebhook"></param>
        /// <param name="withSamples"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.ActivityFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>> ActivityFetchAsync(
            string userId,
            global::Terra.OneOf<int?, global::System.DateTime?> startDate,
            global::Terra.OneOf<int?, global::System.DateTime?>? endDate = default,
            bool? toWebhook = default,
            bool? withSamples = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}