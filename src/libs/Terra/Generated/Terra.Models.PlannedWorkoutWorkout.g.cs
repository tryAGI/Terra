
#nullable enable

namespace Terra
{
    /// <summary>
    /// The workout body, in the same shape for Terra-created and external workouts. Null when a Terra-created workout's body could not be loaded (a warning at path `workout` says why); for an external workout whose steps could not be fetched from the provider, the header fields are present, `step_blocks` is empty and a warning at path `step_blocks` says why.
    /// </summary>
    public sealed partial class PlannedWorkoutWorkout
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}