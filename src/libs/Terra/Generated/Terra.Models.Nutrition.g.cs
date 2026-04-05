
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Nutrition
    {
        /// <summary>
        /// Information on drinks the user consumed throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drink_samples")]
        public global::System.Collections.Generic.IList<global::Terra.DrinkSample>? DrinkSamples { get; set; }

        /// <summary>
        /// Information on individual foods consumed throughout a given day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meals")]
        public global::System.Collections.Generic.IList<global::Terra.Meal>? Meals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.NutritionMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::Terra.NutritionSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Nutrition" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="drinkSamples">
        /// Information on drinks the user consumed throughout the day.
        /// </param>
        /// <param name="meals">
        /// Information on individual foods consumed throughout a given day.
        /// </param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Nutrition(
            global::Terra.NutritionMetadata metadata,
            global::System.Collections.Generic.IList<global::Terra.DrinkSample>? drinkSamples,
            global::System.Collections.Generic.IList<global::Terra.Meal>? meals,
            global::Terra.NutritionSummary? summary)
        {
            this.DrinkSamples = drinkSamples;
            this.Meals = meals;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Nutrition" /> class.
        /// </summary>
        public Nutrition()
        {
        }
    }
}