#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// List planned workouts<br/>
        /// Returns the user's planned workouts, including workouts created on the provider side (is_external true) where the provider exposes them. Every item carries its workout body under `template`, in the same shape for Terra-created and external workouts. External workouts are fetched live from the provider and are not stored by Terra; a workout pushed through Terra that the provider echoes back is listed once, as the Terra row. When the provider could not be read, or a template could not be loaded, the response is still 200 with the rows Terra has and carries the `X-Terra-Provider-Data-Truncated: true` header. Note that providers may limit how far ahead planned workouts are visible.
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
        /// Returns the user's planned workouts, including workouts created on the provider side (is_external true) where the provider exposes them. Every item carries its workout body under `template`, in the same shape for Terra-created and external workouts. External workouts are fetched live from the provider and are not stored by Terra; a workout pushed through Terra that the provider echoes back is listed once, as the Terra row. When the provider could not be read, or a template could not be loaded, the response is still 200 with the rows Terra has and carries the `X-Terra-Provider-Data-Truncated: true` header. Note that providers may limit how far ahead planned workouts are visible.
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