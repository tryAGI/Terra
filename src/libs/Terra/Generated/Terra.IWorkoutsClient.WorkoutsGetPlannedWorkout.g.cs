#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// Get a planned workout<br/>
        /// Returns a planned workout created through Terra. Provider-created (external) workouts are not addressable by id — they are returned by the list endpoint with their full body under `details`.
        /// </summary>
        /// <param name="plannedWorkoutId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.PlannedWorkoutSummary> WorkoutsGetPlannedWorkoutAsync(
            long plannedWorkoutId,
            string userId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a planned workout<br/>
        /// Returns a planned workout created through Terra. Provider-created (external) workouts are not addressable by id — they are returned by the list endpoint with their full body under `details`.
        /// </summary>
        /// <param name="plannedWorkoutId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.PlannedWorkoutSummary>> WorkoutsGetPlannedWorkoutAsResponseAsync(
            long plannedWorkoutId,
            string userId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}