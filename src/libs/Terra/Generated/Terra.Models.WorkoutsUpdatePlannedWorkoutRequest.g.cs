
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkoutsUpdatePlannedWorkoutRequest
    {
        /// <summary>
        /// New scheduled date (YYYY-MM-DD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PlannedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsUpdatePlannedWorkoutRequest" /> class.
        /// </summary>
        /// <param name="plannedDate">
        /// New scheduled date (YYYY-MM-DD)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutsUpdatePlannedWorkoutRequest(
            global::System.DateTime plannedDate)
        {
            this.PlannedDate = plannedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsUpdatePlannedWorkoutRequest" /> class.
        /// </summary>
        public WorkoutsUpdatePlannedWorkoutRequest()
        {
        }

    }
}