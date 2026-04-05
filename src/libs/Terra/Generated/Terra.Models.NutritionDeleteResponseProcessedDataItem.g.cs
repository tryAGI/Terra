
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NutritionDeleteResponseProcessedDataItem
    {
        /// <summary>
        /// Identifier of the nutrition log whose deletion was attempted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Response code from the provider when attempting to delete the nutrition log
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_code")]
        public int? ResponseCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionDeleteResponseProcessedDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the nutrition log whose deletion was attempted
        /// </param>
        /// <param name="responseCode">
        /// Response code from the provider when attempting to delete the nutrition log
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NutritionDeleteResponseProcessedDataItem(
            string? id,
            int? responseCode)
        {
            this.Id = id;
            this.ResponseCode = responseCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionDeleteResponseProcessedDataItem" /> class.
        /// </summary>
        public NutritionDeleteResponseProcessedDataItem()
        {
        }
    }
}