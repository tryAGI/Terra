
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlannedWorkout
    {
        /// <summary>
        /// List of exercises/steps/intervals for the workout plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutSteps>? Steps { get; set; }

        /// <summary>
        /// Metadata for the workout plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Terra.PlannedWorkoutMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkout" /> class.
        /// </summary>
        /// <param name="steps">
        /// List of exercises/steps/intervals for the workout plan
        /// </param>
        /// <param name="metadata">
        /// Metadata for the workout plan
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkout(
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutSteps>? steps,
            global::Terra.PlannedWorkoutMetadata? metadata)
        {
            this.Steps = steps;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkout" /> class.
        /// </summary>
        public PlannedWorkout()
        {
        }
    }
}