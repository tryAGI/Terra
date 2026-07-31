
#nullable enable

namespace Terra
{
    /// <summary>
    /// Object containing the sets, reps and load performed during a strength workout. Absent when the activity carries no strength content, or when the source recorded no usable set breakdown.
    /// </summary>
    public sealed partial class ActivityStrengthData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}