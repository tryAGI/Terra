
#nullable enable

namespace Terra
{
    /// <summary>
    /// The user's bodyweight at the time of the workout, when the source records it. Needed to value bodyweight-based sets, and frequently absent.<br/>
    /// Example: 78.2
    /// </summary>
    public sealed partial class ActivityStrengthDataBodyWeightKg
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}