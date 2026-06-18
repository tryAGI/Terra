
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkoutsPlanWorkoutResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.WorkoutsPlanWorkoutResponseStatusJsonConverter))]
        public global::Terra.WorkoutsPlanWorkoutResponseStatus? Status { get; set; }

        /// <summary>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_workout_id")]
        public string? PlannedWorkoutId { get; set; }

        /// <summary>
        /// Identifier assigned by the provider. Absent for SDK-delivered plans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_workout_id")]
        public string? ProviderWorkoutId { get; set; }

        /// <summary>
        /// Set when the template could not be represented exactly on the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coercion_warnings")]
        public string? CoercionWarnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsPlanWorkoutResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="plannedWorkoutId">
        /// Example: 2048
        /// </param>
        /// <param name="providerWorkoutId">
        /// Identifier assigned by the provider. Absent for SDK-delivered plans.
        /// </param>
        /// <param name="coercionWarnings">
        /// Set when the template could not be represented exactly on the provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutsPlanWorkoutResponse(
            global::Terra.WorkoutsPlanWorkoutResponseStatus? status,
            string? plannedWorkoutId,
            string? providerWorkoutId,
            string? coercionWarnings)
        {
            this.Status = status;
            this.PlannedWorkoutId = plannedWorkoutId;
            this.ProviderWorkoutId = providerWorkoutId;
            this.CoercionWarnings = coercionWarnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsPlanWorkoutResponse" /> class.
        /// </summary>
        public WorkoutsPlanWorkoutResponse()
        {
        }

    }
}