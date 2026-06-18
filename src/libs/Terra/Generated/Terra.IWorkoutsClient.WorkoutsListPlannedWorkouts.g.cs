#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// List planned workouts for a user<br/>
        /// Returns the user's planned workouts, including workouts created on the provider side (is_external true) where the provider exposes them.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Terra.PlannedWorkout>> WorkoutsListPlannedWorkoutsAsync(
            string userId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List planned workouts for a user<br/>
        /// Returns the user's planned workouts, including workouts created on the provider side (is_external true) where the provider exposes them.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Terra.PlannedWorkout>>> WorkoutsListPlannedWorkoutsAsResponseAsync(
            string userId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}