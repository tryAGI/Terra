
#nullable enable

namespace Terra
{
    /// <summary>
    /// What provides the load. Open enum — handle unknown values gracefully; the published vocabulary lists the values in use, and a value outside it must pass through rather than be rejected.<br/>
    /// Example: barbell
    /// </summary>
    public sealed partial class StrengthExerciseModifiersImplement
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}