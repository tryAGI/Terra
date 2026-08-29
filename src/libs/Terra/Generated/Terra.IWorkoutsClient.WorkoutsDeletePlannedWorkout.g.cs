#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// Delete a planned workout<br/>
        /// Removes the planned workout from the user's calendar and from the connected provider.
        /// </summary>
        /// <param name="plannedWorkoutId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task WorkoutsDeletePlannedWorkoutAsync(
            long plannedWorkoutId,
            string userId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a planned workout<br/>
        /// Removes the planned workout from the user's calendar and from the connected provider.
        /// </summary>
        /// <param name="plannedWorkoutId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse> WorkoutsDeletePlannedWorkoutAsResponseAsync(
            long plannedWorkoutId,
            string userId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}