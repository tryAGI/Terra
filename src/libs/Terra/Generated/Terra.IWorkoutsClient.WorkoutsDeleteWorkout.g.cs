#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// Delete a workout template<br/>
        /// Deletes the template and cascades deletion of every planned workout created from it, including removal from connected providers.
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.WorkoutsDeleteWorkoutResponse> WorkoutsDeleteWorkoutAsync(
            string workoutId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a workout template<br/>
        /// Deletes the template and cascades deletion of every planned workout created from it, including removal from connected providers.
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.WorkoutsDeleteWorkoutResponse>> WorkoutsDeleteWorkoutAsResponseAsync(
            string workoutId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}