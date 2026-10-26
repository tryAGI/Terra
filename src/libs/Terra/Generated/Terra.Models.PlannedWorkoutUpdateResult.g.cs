
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlannedWorkoutUpdateResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_workout_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlannedWorkoutId { get; set; }

        /// <summary>
        /// The planned workout's id at the provider after the update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_workout_id")]
        public string? ProviderWorkoutId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PlannedWorkoutUpdateResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.PlannedWorkoutUpdateResultStatus Status { get; set; }

        /// <summary>
        /// Why the planned workout was not updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// What the provider could not take from the new template, as when planning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::Terra.CoercionWarning>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutUpdateResult" /> class.
        /// </summary>
        /// <param name="plannedWorkoutId"></param>
        /// <param name="status"></param>
        /// <param name="providerWorkoutId">
        /// The planned workout's id at the provider after the update.
        /// </param>
        /// <param name="error">
        /// Why the planned workout was not updated.
        /// </param>
        /// <param name="warnings">
        /// What the provider could not take from the new template, as when planning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutUpdateResult(
            string plannedWorkoutId,
            global::Terra.PlannedWorkoutUpdateResultStatus status,
            string? providerWorkoutId,
            string? error,
            global::System.Collections.Generic.IList<global::Terra.CoercionWarning>? warnings)
        {
            this.PlannedWorkoutId = plannedWorkoutId ?? throw new global::System.ArgumentNullException(nameof(plannedWorkoutId));
            this.ProviderWorkoutId = providerWorkoutId;
            this.Status = status;
            this.Error = error;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutUpdateResult" /> class.
        /// </summary>
        public PlannedWorkoutUpdateResult()
        {
        }

    }
}