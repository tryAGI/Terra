#nullable enable

namespace Terra
{
    public partial interface IPlannedWorkoutClient
    {
        /// <summary>
        /// Delete workout plans for a given user ID<br/>
        /// Used to delete workout plans the user has registered on their account. This can be strength workouts (sets, reps, weight lifted) or cardio workouts (warmup, intervals of different intensities, cooldown etc)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.PlannedWorkoutDeleteResponse> PlannedWorkoutDeleteAsync(
            string userId,

            global::Terra.PlannedWorkoutDeleteRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete workout plans for a given user ID<br/>
        /// Used to delete workout plans the user has registered on their account. This can be strength workouts (sets, reps, weight lifted) or cardio workouts (warmup, intervals of different intensities, cooldown etc)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="data">
        /// List of identifiers for planned workout entries to be deleted
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.PlannedWorkoutDeleteResponse> PlannedWorkoutDeleteAsync(
            string userId,
            global::System.Collections.Generic.IList<string>? data = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}