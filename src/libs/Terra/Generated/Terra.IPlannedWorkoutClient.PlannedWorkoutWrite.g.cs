#nullable enable

namespace Terra
{
    public partial interface IPlannedWorkoutClient
    {
        /// <summary>
        /// Post workout plans to a provider<br/>
        /// Used to post workout plans users can follow on their wearable. This can be strength workouts (sets, reps, weight lifted) or cardio workouts (warmup, intervals of different intensities, cooldown etc)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.PlannedWorkoutWriteResponse> PlannedWorkoutWriteAsync(
            string userId,

            global::Terra.PlannedWorkoutWriteRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post workout plans to a provider<br/>
        /// Used to post workout plans users can follow on their wearable. This can be strength workouts (sets, reps, weight lifted) or cardio workouts (warmup, intervals of different intensities, cooldown etc)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="data">
        /// PlannedWorkout entry to post to data provider
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.PlannedWorkoutWriteResponse> PlannedWorkoutWriteAsync(
            string userId,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkout> data,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}