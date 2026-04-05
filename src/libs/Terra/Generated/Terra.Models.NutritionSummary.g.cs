
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NutritionSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("macros")]
        public global::Terra.NutritionMacros? Macros { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("micros")]
        public global::Terra.NutritionMicros? Micros { get; set; }

        /// <summary>
        /// Water consumption of the user for a given day.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("water_ml")]
        public double? WaterMl { get; set; }

        /// <summary>
        /// Non-water drink consumption of the user for a given day.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drink_ml")]
        public double? DrinkMl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionSummary" /> class.
        /// </summary>
        /// <param name="macros"></param>
        /// <param name="micros"></param>
        /// <param name="waterMl">
        /// Water consumption of the user for a given day.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="drinkMl">
        /// Non-water drink consumption of the user for a given day.<br/>
        /// Example: 500
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NutritionSummary(
            global::Terra.NutritionMacros? macros,
            global::Terra.NutritionMicros? micros,
            double? waterMl,
            double? drinkMl)
        {
            this.Macros = macros;
            this.Micros = micros;
            this.WaterMl = waterMl;
            this.DrinkMl = drinkMl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionSummary" /> class.
        /// </summary>
        public NutritionSummary()
        {
        }
    }
}