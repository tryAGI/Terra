
#nullable enable

namespace Terra
{
    /// <summary>
    /// The source's own label for the exercise, passed through verbatim. Present whenever the source names the exercise, whether or not it resolved to a movement. Intended for display.<br/>
    /// Example: Close Grip Bench Press
    /// </summary>
    public sealed partial class StrengthExerciseExerciseName
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}