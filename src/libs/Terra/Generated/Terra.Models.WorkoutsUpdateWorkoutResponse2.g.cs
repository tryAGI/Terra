
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkoutsUpdateWorkoutResponse2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout_id")]
        public string? WorkoutId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_workouts")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutUpdateResult>? PlannedWorkouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsUpdateWorkoutResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="workoutId"></param>
        /// <param name="plannedWorkouts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutsUpdateWorkoutResponse2(
            string? message,
            string? workoutId,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutUpdateResult>? plannedWorkouts)
        {
            this.Message = message;
            this.WorkoutId = workoutId;
            this.PlannedWorkouts = plannedWorkouts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsUpdateWorkoutResponse2" /> class.
        /// </summary>
        public WorkoutsUpdateWorkoutResponse2()
        {
        }

    }
}