
#nullable enable

namespace Terra
{
    /// <summary>
    /// Load as the source logged it: a barbell's total, or one dumbbell. Never negative. Null when load_type is unknown, and may also be null for a load_type you do not recognise.<br/>
    /// Example: 100
    /// </summary>
    public sealed partial class StrengthSetWeightKg
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}