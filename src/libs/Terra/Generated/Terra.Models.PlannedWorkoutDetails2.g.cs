
#nullable enable

namespace Terra
{
    /// <summary>
    /// Full workout body (title, description, planned metrics, structured steps) fetched live from the provider. Present only for external workouts (is_external true).
    /// </summary>
    public sealed partial class PlannedWorkoutDetails2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}