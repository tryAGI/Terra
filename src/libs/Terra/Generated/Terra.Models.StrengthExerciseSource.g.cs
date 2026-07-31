
#nullable enable

namespace Terra
{
    /// <summary>
    /// Where the exercise came from. Open enum — handle unknown values gracefully; the values in use today are user_logged, device_detected and unknown. Only user_logged is user-confirmed. Test for user_logged rather than testing against device_detected, so that a value added later is not trusted by default: anything that is not user_logged may have been inferred by a wearable and may be wrong, rep counts included.
    /// </summary>
    public sealed partial class StrengthExerciseSource
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}