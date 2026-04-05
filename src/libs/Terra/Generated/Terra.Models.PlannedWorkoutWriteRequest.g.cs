
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlannedWorkoutWriteRequest
    {
        /// <summary>
        /// PlannedWorkout entry to post to data provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.PlannedWorkout> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutWriteRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// PlannedWorkout entry to post to data provider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutWriteRequest(
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkout> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutWriteRequest" /> class.
        /// </summary>
        public PlannedWorkoutWriteRequest()
        {
        }
    }
}