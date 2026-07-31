
#nullable enable

namespace Terra
{
    /// <summary>
    /// The muscles the exercise works without being the focus, as reported by the source. Kept apart from primary_muscles because the distinction drives recovery and volume-per-muscle, which merging the two would lose. Empty means the source did not say. Open enum — handle unknown values gracefully.
    /// </summary>
    public sealed partial class StrengthExerciseSecondaryMuscles
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}