
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// A workout scheduled onto a user's calendar, whether created through Terra or on the provider side
    /// </summary>
    public sealed partial class PlannedWorkout
    {
        /// <summary>
        /// Terra identifier of the planned workout. Null for workouts created on the provider side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_workout_id")]
        public string? PlannedWorkoutId { get; set; }

        /// <summary>
        /// Identifier of the workout template this was planned from. Null for workouts created on the provider side; a non-null value means the workout is managed through Terra and can be rescheduled or deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout_id")]
        public string? WorkoutId { get; set; }

        /// <summary>
        /// Scheduled date (YYYY-MM-DD). Null for provider entries that are not attached to a date, such as a routine library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_date")]
        public string? PlannedDate { get; set; }

        /// <summary>
        /// Identifier of the workout on the provider's side, in the form the provider's own API uses for it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_workout_id")]
        public string? ProviderWorkoutId { get; set; }

        /// <summary>
        /// Deprecated: the stored JSON text of the adjustments made when the template was pushed to the provider; use `warnings`. Null when there were none or the workout was created on the provider side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coercion_warnings")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? CoercionWarnings { get; set; }

        /// <summary>
        /// Adjustments made while converting between Terra's template and the provider's format. On Terra-created workouts these come from the push to the provider; on external workouts, from reading the provider's workout into a template. Empty when the conversion was exact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.CoercionWarning> Warnings { get; set; }

        /// <summary>
        /// Creation time (RFC 3339). Null for external workouts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Last update time (RFC 3339). Null for external workouts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public string? LastUpdatedAt { get; set; }

        /// <summary>
        /// True when the workout was created on the provider side rather than through Terra
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_external")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsExternal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete_metrics")]
        public global::Terra.AthleteMetrics? AthleteMetrics { get; set; }

        /// <summary>
        /// The workout body, in the same shape for Terra-created and external workouts. Null when a Terra-created workout's body could not be loaded (a warning at path `workout` says why); for an external workout whose steps could not be fetched from the provider, the header fields are present, `step_blocks` is empty and a warning at path `step_blocks` says why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout")]
        public global::Terra.PlannedWorkoutBody? Workout { get; set; }

        /// <summary>
        /// Deprecated. The provider body of an external workout in its pre-template shape; use `workout`. Null on Terra-created workouts. Removed in the next major SDK release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Terra.PlannedWorkoutDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkout" /> class.
        /// </summary>
        /// <param name="warnings">
        /// Adjustments made while converting between Terra's template and the provider's format. On Terra-created workouts these come from the push to the provider; on external workouts, from reading the provider's workout into a template. Empty when the conversion was exact.
        /// </param>
        /// <param name="isExternal">
        /// True when the workout was created on the provider side rather than through Terra
        /// </param>
        /// <param name="plannedWorkoutId">
        /// Terra identifier of the planned workout. Null for workouts created on the provider side.
        /// </param>
        /// <param name="workoutId">
        /// Identifier of the workout template this was planned from. Null for workouts created on the provider side; a non-null value means the workout is managed through Terra and can be rescheduled or deleted.
        /// </param>
        /// <param name="plannedDate">
        /// Scheduled date (YYYY-MM-DD). Null for provider entries that are not attached to a date, such as a routine library.
        /// </param>
        /// <param name="providerWorkoutId">
        /// Identifier of the workout on the provider's side, in the form the provider's own API uses for it
        /// </param>
        /// <param name="createdAt">
        /// Creation time (RFC 3339). Null for external workouts.
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Last update time (RFC 3339). Null for external workouts.
        /// </param>
        /// <param name="athleteMetrics"></param>
        /// <param name="workout">
        /// The workout body, in the same shape for Terra-created and external workouts. Null when a Terra-created workout's body could not be loaded (a warning at path `workout` says why); for an external workout whose steps could not be fetched from the provider, the header fields are present, `step_blocks` is empty and a warning at path `step_blocks` says why.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkout(
            global::System.Collections.Generic.IList<global::Terra.CoercionWarning> warnings,
            bool isExternal,
            string? plannedWorkoutId,
            string? workoutId,
            string? plannedDate,
            string? providerWorkoutId,
            string? createdAt,
            string? lastUpdatedAt,
            global::Terra.AthleteMetrics? athleteMetrics,
            global::Terra.PlannedWorkoutBody? workout)
        {
            this.PlannedWorkoutId = plannedWorkoutId;
            this.WorkoutId = workoutId;
            this.PlannedDate = plannedDate;
            this.ProviderWorkoutId = providerWorkoutId;
            this.Warnings = warnings ?? throw new global::System.ArgumentNullException(nameof(warnings));
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.IsExternal = isExternal;
            this.AthleteMetrics = athleteMetrics;
            this.Workout = workout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkout" /> class.
        /// </summary>
        public PlannedWorkout()
        {
        }

    }
}