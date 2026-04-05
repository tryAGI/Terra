
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlannedWorkoutDeleteResponse5
    {
        /// <summary>
        /// a detailed message describing the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// indicates that an error happened (value is error)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatus3JsonConverter))]
        public global::Terra.PlannedWorkoutDeleteResponseStatus3? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDeleteResponse5" /> class.
        /// </summary>
        /// <param name="message">
        /// a detailed message describing the error
        /// </param>
        /// <param name="status">
        /// indicates that an error happened (value is error)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutDeleteResponse5(
            string? message,
            global::Terra.PlannedWorkoutDeleteResponseStatus3? status)
        {
            this.Message = message;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDeleteResponse5" /> class.
        /// </summary>
        public PlannedWorkoutDeleteResponse5()
        {
        }
    }
}