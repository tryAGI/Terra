
#nullable enable

namespace Terra
{
    /// <summary>
    /// Object containing information on data for each lap performed by the user - mostly relates to track &amp; field running activities, and swimming activities.
    /// </summary>
    public sealed partial class ActivityLapData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}