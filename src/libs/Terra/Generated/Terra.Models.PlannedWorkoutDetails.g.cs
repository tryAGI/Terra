
#nullable enable

namespace Terra
{
    /// <summary>
    /// Full body of a provider-side planned workout, fetched live from the provider. Present only on external planned workouts (is_external true), which have no Terra workout template.
    /// </summary>
    public sealed partial class PlannedWorkoutDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Terra.PlannedWorkoutDetailsMetadata? Metadata { get; set; }

        /// <summary>
        /// Structured steps of the workout, when the provider exposes them
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStep>? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetails" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="steps">
        /// Structured steps of the workout, when the provider exposes them
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutDetails(
            global::Terra.PlannedWorkoutDetailsMetadata? metadata,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStep>? steps)
        {
            this.Metadata = metadata;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetails" /> class.
        /// </summary>
        public PlannedWorkoutDetails()
        {
        }

    }
}