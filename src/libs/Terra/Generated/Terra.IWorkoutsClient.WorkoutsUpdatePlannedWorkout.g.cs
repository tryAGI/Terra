#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// Reschedule a planned workout
        /// </summary>
        /// <param name="plannedWorkoutId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.PlannedWorkoutSummary> WorkoutsUpdatePlannedWorkoutAsync(
            string plannedWorkoutId,

            global::Terra.WorkoutsUpdatePlannedWorkoutRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reschedule a planned workout
        /// </summary>
        /// <param name="plannedWorkoutId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.PlannedWorkoutSummary>> WorkoutsUpdatePlannedWorkoutAsResponseAsync(
            string plannedWorkoutId,

            global::Terra.WorkoutsUpdatePlannedWorkoutRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reschedule a planned workout
        /// </summary>
        /// <param name="plannedWorkoutId"></param>
        /// <param name="plannedDate">
        /// New scheduled date (YYYY-MM-DD)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.PlannedWorkoutSummary> WorkoutsUpdatePlannedWorkoutAsync(
            string plannedWorkoutId,
            global::System.DateTime plannedDate,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}