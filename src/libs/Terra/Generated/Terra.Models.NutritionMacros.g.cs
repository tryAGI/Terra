
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NutritionMacros
    {
        /// <summary>
        /// Alcohol content of the associated food(s).<br/>
        /// Example: 14
        /// </summary>
        /// <example>14</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alcohol_g")]
        public double? AlcoholG { get; set; }

        /// <summary>
        /// Calorie content of the associated food(s).<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public double? Calories { get; set; }

        /// <summary>
        /// Carbohydrates content of the associated food(s).<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("carbohydrates_g")]
        public double? CarbohydratesG { get; set; }

        /// <summary>
        /// Cholesterol content of the associated food(s).<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cholesterol_mg")]
        public double? CholesterolMg { get; set; }

        /// <summary>
        /// Fat content of the associated food(s).<br/>
        /// Example: 65
        /// </summary>
        /// <example>65</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fat_g")]
        public double? FatG { get; set; }

        /// <summary>
        /// Fiber content of the associated food(s).<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fiber_g")]
        public double? FiberG { get; set; }

        /// <summary>
        /// Net carbs content of the associated food(s).<br/>
        /// Example: 275
        /// </summary>
        /// <example>275</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("net_carbohydrates_g")]
        public double? NetCarbohydratesG { get; set; }

        /// <summary>
        /// Protein content of the associated food(s).<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("protein_g")]
        public double? ProteinG { get; set; }

        /// <summary>
        /// Saturated fat content of the associated food(s).<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("saturated_fat_g")]
        public double? SaturatedFatG { get; set; }

        /// <summary>
        /// Sodium content of the associated food(s).<br/>
        /// Example: 2300
        /// </summary>
        /// <example>2300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sodium_mg")]
        public double? SodiumMg { get; set; }

        /// <summary>
        /// Sugar content of the associated food(s).<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sugar_g")]
        public double? SugarG { get; set; }

        /// <summary>
        /// Trans fat content of the associated food(s).<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trans_fat_g")]
        public double? TransFatG { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionMacros" /> class.
        /// </summary>
        /// <param name="alcoholG">
        /// Alcohol content of the associated food(s).<br/>
        /// Example: 14
        /// </param>
        /// <param name="calories">
        /// Calorie content of the associated food(s).<br/>
        /// Example: 2000
        /// </param>
        /// <param name="carbohydratesG">
        /// Carbohydrates content of the associated food(s).<br/>
        /// Example: 300
        /// </param>
        /// <param name="cholesterolMg">
        /// Cholesterol content of the associated food(s).<br/>
        /// Example: 300
        /// </param>
        /// <param name="fatG">
        /// Fat content of the associated food(s).<br/>
        /// Example: 65
        /// </param>
        /// <param name="fiberG">
        /// Fiber content of the associated food(s).<br/>
        /// Example: 25
        /// </param>
        /// <param name="netCarbohydratesG">
        /// Net carbs content of the associated food(s).<br/>
        /// Example: 275
        /// </param>
        /// <param name="proteinG">
        /// Protein content of the associated food(s).<br/>
        /// Example: 50
        /// </param>
        /// <param name="saturatedFatG">
        /// Saturated fat content of the associated food(s).<br/>
        /// Example: 20
        /// </param>
        /// <param name="sodiumMg">
        /// Sodium content of the associated food(s).<br/>
        /// Example: 2300
        /// </param>
        /// <param name="sugarG">
        /// Sugar content of the associated food(s).<br/>
        /// Example: 25
        /// </param>
        /// <param name="transFatG">
        /// Trans fat content of the associated food(s).<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NutritionMacros(
            double? alcoholG,
            double? calories,
            double? carbohydratesG,
            double? cholesterolMg,
            double? fatG,
            double? fiberG,
            double? netCarbohydratesG,
            double? proteinG,
            double? saturatedFatG,
            double? sodiumMg,
            double? sugarG,
            double? transFatG)
        {
            this.AlcoholG = alcoholG;
            this.Calories = calories;
            this.CarbohydratesG = carbohydratesG;
            this.CholesterolMg = cholesterolMg;
            this.FatG = fatG;
            this.FiberG = fiberG;
            this.NetCarbohydratesG = netCarbohydratesG;
            this.ProteinG = proteinG;
            this.SaturatedFatG = saturatedFatG;
            this.SodiumMg = sodiumMg;
            this.SugarG = sugarG;
            this.TransFatG = transFatG;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionMacros" /> class.
        /// </summary>
        public NutritionMacros()
        {
        }
    }
}