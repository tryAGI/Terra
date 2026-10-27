
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkoutUpdateResponse
    {
        /// <summary>
        /// Present when every reachable planned workout was updated (200).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.WorkoutUpdateResponseStatusJsonConverter))]
        public global::Terra.WorkoutUpdateResponseStatus? Status { get; set; }

        /// <summary>
        /// Present when some re-sends failed (207). Repeat the request to re-send them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkoutId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_workouts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutUpdateResult> PlannedWorkouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutUpdateResponse" /> class.
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="plannedWorkouts"></param>
        /// <param name="status">
        /// Present when every reachable planned workout was updated (200).
        /// </param>
        /// <param name="message">
        /// Present when some re-sends failed (207). Repeat the request to re-send them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutUpdateResponse(
            string workoutId,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutUpdateResult> plannedWorkouts,
            global::Terra.WorkoutUpdateResponseStatus? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
            this.WorkoutId = workoutId ?? throw new global::System.ArgumentNullException(nameof(workoutId));
            this.PlannedWorkouts = plannedWorkouts ?? throw new global::System.ArgumentNullException(nameof(plannedWorkouts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutUpdateResponse" /> class.
        /// </summary>
        public WorkoutUpdateResponse()
        {
        }

    }
}