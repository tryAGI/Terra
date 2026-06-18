
#nullable enable

namespace Terra
{
    /// <summary>
    /// Object containing information on the user's readiness for the day, based off the quality and duration of their sleep.
    /// </summary>
    public sealed partial class SleepReadinessData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}