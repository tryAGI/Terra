#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// List planned workouts<br/>
        /// Returns the user's planned workouts, including workouts created on the provider side (is_external true) where the provider exposes them. External workouts carry their full body (title, description, planned metrics, structured steps) under `details`; they are fetched live from the provider and are not stored by Terra. Note that providers may limit how far ahead planned workouts are visible.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Terra.PlannedWorkout>> WorkoutsListPlannedWorkoutsAsync(
            string userId,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List planned workouts<br/>
        /// Returns the user's planned workouts, including workouts created on the provider side (is_external true) where the provider exposes them. External workouts carry their full body (title, description, planned metrics, structured steps) under `details`; they are fetched live from the provider and are not stored by Terra. Note that providers may limit how far ahead planned workouts are visible.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Terra.PlannedWorkout>>> WorkoutsListPlannedWorkoutsAsResponseAsync(
            string userId,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}