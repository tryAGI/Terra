
#nullable enable

namespace Terra
{
    /// <summary>
    /// A workout template scheduled onto a user's calendar
    /// </summary>
    public sealed partial class PlannedWorkout
    {
        /// <summary>
        /// Terra identifier of the planned workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_workout_id")]
        public string? PlannedWorkoutId { get; set; }

        /// <summary>
        /// Identifier of the workout template this was planned from. Absent for workouts created on the provider side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout_id")]
        public string? WorkoutId { get; set; }

        /// <summary>
        /// Scheduled date (YYYY-MM-DD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_date")]
        public string? PlannedDate { get; set; }

        /// <summary>
        /// Identifier of the workout on the provider's side, once pushed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_workout_id")]
        public string? ProviderWorkoutId { get; set; }

        /// <summary>
        /// Warnings emitted when the template could not be represented exactly on the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coercion_warnings")]
        public string? CoercionWarnings { get; set; }

        /// <summary>
        /// Creation time (RFC 3339)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Last update time (RFC 3339)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public string? LastUpdatedAt { get; set; }

        /// <summary>
        /// True when the workout was created on the provider side rather than through Terra
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_external")]
        public bool? IsExternal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete_metrics")]
        public global::Terra.AthleteMetrics? AthleteMetrics { get; set; }

        /// <summary>
        /// Full workout body (title, description, planned metrics, structured steps) fetched live from the provider. Present only for external workouts (is_external true).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Terra.PlannedWorkoutDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkout" /> class.
        /// </summary>
        /// <param name="plannedWorkoutId">
        /// Terra identifier of the planned workout
        /// </param>
        /// <param name="workoutId">
        /// Identifier of the workout template this was planned from. Absent for workouts created on the provider side.
        /// </param>
        /// <param name="plannedDate">
        /// Scheduled date (YYYY-MM-DD)
        /// </param>
        /// <param name="providerWorkoutId">
        /// Identifier of the workout on the provider's side, once pushed
        /// </param>
        /// <param name="coercionWarnings">
        /// Warnings emitted when the template could not be represented exactly on the provider
        /// </param>
        /// <param name="createdAt">
        /// Creation time (RFC 3339)
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Last update time (RFC 3339)
        /// </param>
        /// <param name="isExternal">
        /// True when the workout was created on the provider side rather than through Terra
        /// </param>
        /// <param name="athleteMetrics"></param>
        /// <param name="details">
        /// Full workout body (title, description, planned metrics, structured steps) fetched live from the provider. Present only for external workouts (is_external true).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkout(
            string? plannedWorkoutId,
            string? workoutId,
            string? plannedDate,
            string? providerWorkoutId,
            string? coercionWarnings,
            string? createdAt,
            string? lastUpdatedAt,
            bool? isExternal,
            global::Terra.AthleteMetrics? athleteMetrics,
            global::Terra.PlannedWorkoutDetails? details)
        {
            this.PlannedWorkoutId = plannedWorkoutId;
            this.WorkoutId = workoutId;
            this.PlannedDate = plannedDate;
            this.ProviderWorkoutId = providerWorkoutId;
            this.CoercionWarnings = coercionWarnings;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.IsExternal = isExternal;
            this.AthleteMetrics = athleteMetrics;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkout" /> class.
        /// </summary>
        public PlannedWorkout()
        {
        }

    }
}