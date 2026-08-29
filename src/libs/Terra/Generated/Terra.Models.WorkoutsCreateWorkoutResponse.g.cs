
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkoutsCreateWorkoutResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.WorkoutsCreateWorkoutResponseStatusJsonConverter))]
        public global::Terra.WorkoutsCreateWorkoutResponseStatus? Status { get; set; }

        /// <summary>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout_id")]
        public string? WorkoutId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsCreateWorkoutResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="workoutId">
        /// Example: 1024
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutsCreateWorkoutResponse(
            global::Terra.WorkoutsCreateWorkoutResponseStatus? status,
            string? workoutId)
        {
            this.Status = status;
            this.WorkoutId = workoutId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsCreateWorkoutResponse" /> class.
        /// </summary>
        public WorkoutsCreateWorkoutResponse()
        {
        }

    }
}