
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NutritionWriteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Terra.TerraUser? User { get; set; }

        /// <summary>
        /// List of identifiers for the objects created, returned in the same order they were posted. I.e. Posting [ObjectA, ObjectB] will return [IdentifierA, IdentifierB]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_ids")]
        public global::System.Collections.Generic.IList<string>? LogIds { get; set; }

        /// <summary>
        /// Default Value: Nutrition successfully logged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionWriteResponse" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="logIds">
        /// List of identifiers for the objects created, returned in the same order they were posted. I.e. Posting [ObjectA, ObjectB] will return [IdentifierA, IdentifierB]
        /// </param>
        /// <param name="message">
        /// Default Value: Nutrition successfully logged
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NutritionWriteResponse(
            global::Terra.TerraUser? user,
            global::System.Collections.Generic.IList<string>? logIds,
            string? message)
        {
            this.User = user;
            this.LogIds = logIds;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionWriteResponse" /> class.
        /// </summary>
        public NutritionWriteResponse()
        {
        }
    }
}