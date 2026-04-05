#nullable enable

namespace Terra
{
    public partial interface IPlannedWorkoutClient
    {
        /// <summary>
        /// Retrieve workout plans for a given user ID<br/>
        /// Used to get workout plans the user has registered on their account. This can be strength workouts (sets, reps, weight lifted) or cardio workouts (warmup, intervals of different intensities, cooldown etc)
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="toWebhook"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.PlannedWorkoutFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook>> PlannedWorkoutFetchAsync(
            string userId,
            global::Terra.OneOf<int?, global::System.DateTime?> startDate,
            global::Terra.OneOf<int?, global::System.DateTime?>? endDate = default,
            bool? toWebhook = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}