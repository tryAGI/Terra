
#nullable enable

namespace Terra
{
    /// <summary>
    /// Bands or chains added to another implement — not a second implement. The reported weight_kg is the bar alone, since band tension is not expressed in kg, so this also signals that the recorded load understates the real resistance. Open enum.
    /// </summary>
    public sealed partial class StrengthExerciseModifiersAccommodatingResistance
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}