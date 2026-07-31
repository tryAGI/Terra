
#nullable enable

namespace Terra
{
    /// <summary>
    /// The muscles the exercise primarily works, as reported by the source. A list because providers differ: some name exactly one, some name several for the same exercise, and some name none. Empty means the source did not say, not that no muscle is worked. Open enum — handle unknown values gracefully.
    /// </summary>
    public sealed partial class StrengthExercisePrimaryMuscles
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}