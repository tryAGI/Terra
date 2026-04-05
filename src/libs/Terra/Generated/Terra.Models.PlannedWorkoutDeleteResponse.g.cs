
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlannedWorkoutDeleteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Terra.TerraUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_data")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDeleteResponseProcessedDataItem>? ProcessedData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDeleteResponse" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="processedData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutDeleteResponse(
            global::Terra.TerraUser? user,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDeleteResponseProcessedDataItem>? processedData)
        {
            this.User = user;
            this.ProcessedData = processedData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDeleteResponse" /> class.
        /// </summary>
        public PlannedWorkoutDeleteResponse()
        {
        }
    }
}