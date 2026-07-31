
#nullable enable

namespace Terra
{
    /// <summary>
    /// The joint actions performed, in the order one repetition performs them, with implement, grip, stance, tempo and position all carried in modifiers. Usually one; a clean and jerk is [clean, jerk]. This is the rollup axis, and membership is what to test: a clean and jerk belongs in both clean volume and jerk volume, so ask whether movements contains the value rather than equals it. Open enum — handle unknown values gracefully. Empty when the exercise could not be resolved, in which case exercise_name still says what the source called it.
    /// </summary>
    public sealed partial class StrengthExerciseMovements
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}