#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// Plan a workout onto a user's calendar<br/>
        /// Schedules the workout template for a user on a given date and pushes it to the user's connected provider (or queues it for SDK delivery). Athlete metrics personalise zone-based targets for this plan only.
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.WorkoutsPlanWorkoutResponse> WorkoutsPlanWorkoutAsync(
            long workoutId,
            string userId,

            global::Terra.WorkoutsPlanWorkoutRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Plan a workout onto a user's calendar<br/>
        /// Schedules the workout template for a user on a given date and pushes it to the user's connected provider (or queues it for SDK delivery). Athlete metrics personalise zone-based targets for this plan only.
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.WorkoutsPlanWorkoutResponse>> WorkoutsPlanWorkoutAsResponseAsync(
            long workoutId,
            string userId,

            global::Terra.WorkoutsPlanWorkoutRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Plan a workout onto a user's calendar<br/>
        /// Schedules the workout template for a user on a given date and pushes it to the user's connected provider (or queues it for SDK delivery). Athlete metrics personalise zone-based targets for this plan only.
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="userId"></param>
        /// <param name="plannedDate">
        /// Date to schedule the workout on (YYYY-MM-DD)
        /// </param>
        /// <param name="ftp">
        /// Functional Threshold Power in watts
        /// </param>
        /// <param name="maxHeartRate">
        /// Maximum heart rate in BPM
        /// </param>
        /// <param name="thresholdHeartRate">
        /// Threshold heart rate in BPM
        /// </param>
        /// <param name="thresholdSpeed">
        /// Threshold speed in m/s
        /// </param>
        /// <param name="poolLengthMeters">
        /// Pool length in meters (overrides the template value)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.WorkoutsPlanWorkoutResponse> WorkoutsPlanWorkoutAsync(
            long workoutId,
            string userId,
            global::System.DateTime plannedDate,
            double? ftp = default,
            double? maxHeartRate = default,
            double? thresholdHeartRate = default,
            double? thresholdSpeed = default,
            double? poolLengthMeters = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}