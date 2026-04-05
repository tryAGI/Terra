#nullable enable

namespace Terra
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Post activity data to a provider<br/>
        /// Used to post activity data to a provider. This endpoint only works for users connected via Wahoo. Returns error for other providers.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.ActivityWriteResponse> ActivityWriteAsync(

            global::Terra.ActivityWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post activity data to a provider<br/>
        /// Used to post activity data to a provider. This endpoint only works for users connected via Wahoo. Returns error for other providers.
        /// </summary>
        /// <param name="data">
        /// List of user-tracked workouts to post to data provider
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.ActivityWriteResponse> ActivityWriteAsync(
            global::System.Collections.Generic.IList<global::Terra.Activity> data,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}