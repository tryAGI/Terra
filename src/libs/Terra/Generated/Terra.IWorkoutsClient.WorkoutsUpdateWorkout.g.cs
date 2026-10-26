#nullable enable

namespace Terra
{
    public partial interface IWorkoutsClient
    {
        /// <summary>
        /// Update a workout template<br/>
        /// Replaces the template and re-sends it to every upcoming planned workout made from it, each under its existing provider id. Completed and past planned workouts keep the version they were sent. An Apple Health planned workout already on the device is queued to fetch the new version, as a reschedule is. Each re-send to a provider is billed like a reschedule. The response lists every planned workout's outcome; `skipped` ones cannot be re-sent (for example, the user has disconnected), and a `failed` one is re-sent by repeating the request.
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.WorkoutsUpdateWorkoutResponse> WorkoutsUpdateWorkoutAsync(
            long workoutId,

            global::Terra.WorkoutTemplate request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a workout template<br/>
        /// Replaces the template and re-sends it to every upcoming planned workout made from it, each under its existing provider id. Completed and past planned workouts keep the version they were sent. An Apple Health planned workout already on the device is queued to fetch the new version, as a reschedule is. Each re-send to a provider is billed like a reschedule. The response lists every planned workout's outcome; `skipped` ones cannot be re-sent (for example, the user has disconnected), and a `failed` one is re-sent by repeating the request.
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.WorkoutsUpdateWorkoutResponse>> WorkoutsUpdateWorkoutAsResponseAsync(
            long workoutId,

            global::Terra.WorkoutTemplate request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a workout template<br/>
        /// Replaces the template and re-sends it to every upcoming planned workout made from it, each under its existing provider id. Completed and past planned workouts keep the version they were sent. An Apple Health planned workout already on the device is queued to fetch the new version, as a reschedule is. Each re-send to a provider is billed like a reschedule. The response lists every planned workout's outcome; `skipped` ones cannot be re-sent (for example, the user has disconnected), and a `failed` one is re-sent by repeating the request.
        /// </summary>
        /// <param name="workoutId"></param>
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
        /// Planned training stress score (0-9999), where the provider or author supplies one. Forwarded to TrainingPeaks, which ignores it when any step target is not RPE and derives it from the structure instead.
        /// </param>
        /// <param name="estimatedIntensityFactor">
        /// Planned intensity factor (0-5), where the provider or author supplies one. Forwarded to TrainingPeaks, which ignores it when any step target is not RPE and derives it from the structure instead.
        /// </param>
        /// <param name="requestWorkoutId">
        /// Terra identifier of the stored template. Set by Terra in responses; ignored on create.
        /// </param>
        /// <param name="sport">
        /// Sport a workout template targets. Indoor/outdoor is expressed separately via environment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.WorkoutsUpdateWorkoutResponse> WorkoutsUpdateWorkoutAsync(
            long workoutId,
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
            string? requestWorkoutId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}