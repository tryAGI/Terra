
#nullable enable

namespace Terra
{
    /// <summary>
    /// A block of steps, repeated until its completion condition is met
    /// </summary>
    public sealed partial class StepBlock
    {
        /// <summary>
        /// Condition that completes a step or repeats a step block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.CompletionCondition CompletionCondition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.WorkoutStep> Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepBlock" /> class.
        /// </summary>
        /// <param name="completionCondition">
        /// Condition that completes a step or repeats a step block
        /// </param>
        /// <param name="steps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepBlock(
            global::Terra.CompletionCondition completionCondition,
            global::System.Collections.Generic.IList<global::Terra.WorkoutStep> steps)
        {
            this.CompletionCondition = completionCondition ?? throw new global::System.ArgumentNullException(nameof(completionCondition));
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepBlock" /> class.
        /// </summary>
        public StepBlock()
        {
        }

    }
}