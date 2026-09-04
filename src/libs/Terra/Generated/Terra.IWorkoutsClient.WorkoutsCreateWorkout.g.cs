#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// Create a workout template<br/>
        /// Stores a reusable workout template. Plan it onto a user's calendar with `POST /workouts/{workout_id}/plan`; the template itself carries no date and is not pushed to any provider until planned.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.WorkoutsCreateWorkoutResponse> WorkoutsCreateWorkoutAsync(

            global::Terra.WorkoutTemplate request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a workout template<br/>
        /// Stores a reusable workout template. Plan it onto a user's calendar with `POST /workouts/{workout_id}/plan`; the template itself carries no date and is not pushed to any provider until planned.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.WorkoutsCreateWorkoutResponse>> WorkoutsCreateWorkoutAsResponseAsync(

            global::Terra.WorkoutTemplate request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a workout template<br/>
        /// Stores a reusable workout template. Plan it onto a user's calendar with `POST /workouts/{workout_id}/plan`; the template itself carries no date and is not pushed to any provider until planned.
        /// </summary>
        /// <param name="name">
        /// Name of the workout
        /// </param>
        /// <param name="description">
        /// Description of the workout
        /// </param>
        /// <param name="environment"></param>
        /// <param name="poolLengthMeters">
        /// Pool length in meters, for swim workouts
        /// </param>
        /// <param name="stepBlocks"></param>
        /// <param name="estimatedDurationSeconds">
        /// Estimated total duration in seconds
        /// </param>
        /// <param name="estimatedDistanceMeters">
        /// Estimated total distance in meters
        /// </param>
        /// <param name="estimatedCalories">
        /// Estimated calories burned
        /// </param>
        /// <param name="estimatedTss">
        /// Planned training stress score, where the provider or author supplies one. Read-only today: accepted on create but not forwarded to providers.
        /// </param>
        /// <param name="estimatedIntensityFactor">
        /// Planned intensity factor, where the provider or author supplies one. Read-only today: accepted on create but not forwarded to providers.
        /// </param>
        /// <param name="workoutId">
        /// Terra identifier of the stored template. Set by Terra in responses; ignored on create.
        /// </param>
        /// <param name="sport">
        /// Sport a workout template targets. Indoor/outdoor is expressed separately via environment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.WorkoutsCreateWorkoutResponse> WorkoutsCreateWorkoutAsync(
            string name,
            global::System.Collections.Generic.IList<global::Terra.StepBlock> stepBlocks,
            global::Terra.WorkoutSport sport,
            string? description = default,
            global::Terra.EnvironmentType? environment = default,
            double? poolLengthMeters = default,
            double? estimatedDurationSeconds = default,
            double? estimatedDistanceMeters = default,
            double? estimatedCalories = default,
            double? estimatedTss = default,
            double? estimatedIntensityFactor = default,
            string? workoutId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}