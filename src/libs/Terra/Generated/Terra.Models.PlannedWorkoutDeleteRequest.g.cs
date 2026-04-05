
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlannedWorkoutDeleteRequest
    {
        /// <summary>
        /// List of identifiers for planned workout entries to be deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<string>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDeleteRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// List of identifiers for planned workout entries to be deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutDeleteRequest(
            global::System.Collections.Generic.IList<string>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDeleteRequest" /> class.
        /// </summary>
        public PlannedWorkoutDeleteRequest()
        {
        }
    }
}