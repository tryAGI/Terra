
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Summary of a planned workout, returned by the get and reschedule operations.
    /// </summary>
    public sealed partial class PlannedWorkoutSummary
    {
        /// <summary>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_workout_id")]
        public string? PlannedWorkoutId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_date")]
        public global::System.DateTime? PlannedDate { get; set; }

        /// <summary>
        /// True when the workout was created on the provider side rather than through Terra.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_external")]
        public bool? IsExternal { get; set; }

        /// <summary>
        /// Identifier of the source template. Absent for external workouts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout_id")]
        public string? WorkoutId { get; set; }

        /// <summary>
        /// Identifier assigned by the provider, once pushed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_workout_id")]
        public string? ProviderWorkoutId { get; set; }

        /// <summary>
        /// Deprecated; use warnings. Set when the template could not be represented exactly on the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coercion_warnings")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? CoercionWarnings { get; set; }

        /// <summary>
        /// Adjustments made when the template could not be represented exactly on the provider. Empty when the push was exact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::Terra.CoercionWarning>? Warnings { get; set; }

        /// <summary>
        /// The workout body, as on the list. Null when the planned workout has no stored template or it could not be loaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout")]
        public global::Terra.PlannedWorkoutBody? Workout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutSummary" /> class.
        /// </summary>
        /// <param name="plannedWorkoutId">
        /// Example: 2048
        /// </param>
        /// <param name="plannedDate"></param>
        /// <param name="isExternal">
        /// True when the workout was created on the provider side rather than through Terra.
        /// </param>
        /// <param name="workoutId">
        /// Identifier of the source template. Absent for external workouts.
        /// </param>
        /// <param name="providerWorkoutId">
        /// Identifier assigned by the provider, once pushed.
        /// </param>
        /// <param name="warnings">
        /// Adjustments made when the template could not be represented exactly on the provider. Empty when the push was exact.
        /// </param>
        /// <param name="workout">
        /// The workout body, as on the list. Null when the planned workout has no stored template or it could not be loaded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutSummary(
            string? plannedWorkoutId,
            global::System.DateTime? plannedDate,
            bool? isExternal,
            string? workoutId,
            string? providerWorkoutId,
            global::System.Collections.Generic.IList<global::Terra.CoercionWarning>? warnings,
            global::Terra.PlannedWorkoutBody? workout)
        {
            this.PlannedWorkoutId = plannedWorkoutId;
            this.PlannedDate = plannedDate;
            this.IsExternal = isExternal;
            this.WorkoutId = workoutId;
            this.ProviderWorkoutId = providerWorkoutId;
            this.Warnings = warnings;
            this.Workout = workout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutSummary" /> class.
        /// </summary>
        public PlannedWorkoutSummary()
        {
        }

    }
}