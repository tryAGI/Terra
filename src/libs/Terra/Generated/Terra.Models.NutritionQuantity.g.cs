
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NutritionQuantity
    {
        /// <summary>
        /// Represents units used for nutrition measurements
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionQuantity" /> class.
        /// </summary>
        /// <param name="unit">
        /// Represents units used for nutrition measurements
        /// </param>
        /// <param name="amount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NutritionQuantity(
            double unit,
            double amount)
        {
            this.Unit = unit;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionQuantity" /> class.
        /// </summary>
        public NutritionQuantity()
        {
        }
    }
}