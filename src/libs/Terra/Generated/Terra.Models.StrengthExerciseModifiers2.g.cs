
#nullable enable

namespace Terra
{
    /// <summary>
    /// The axes that qualify the exercise. An axis that is absent was not reported by the source — it does NOT mean a default applies, so a squat with no implement is not the same as a bodyweight squat. Axes describe the exercise as performed rather than each movement separately: in a step up to a deficit reverse lunge only the lunge is at a deficit, but the axis describes the whole exercise and exercise_name carries the detail.
    /// </summary>
    public sealed partial class StrengthExerciseModifiers2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}