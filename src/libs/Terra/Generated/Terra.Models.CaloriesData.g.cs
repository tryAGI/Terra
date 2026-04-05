
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaloriesData
    {
        /// <summary>
        /// Basal Metabolic Rate calories - calories burned at rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("BMR_calories")]
        public double? BmrCalories { get; set; }

        /// <summary>
        /// Array of calorie data samples recorded throughout the time period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calorie_samples")]
        public global::System.Collections.Generic.IList<global::Terra.CalorieSample>? CalorieSamples { get; set; }

        /// <summary>
        /// Net calories burned through activity (excluding BMR).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("net_activity_calories")]
        public double? NetActivityCalories { get; set; }

        /// <summary>
        /// Net calories consumed through food and drink intake.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("net_intake_calories")]
        public double? NetIntakeCalories { get; set; }

        /// <summary>
        /// Total calories burned including BMR and activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_burned_calories")]
        public double? TotalBurnedCalories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaloriesData" /> class.
        /// </summary>
        /// <param name="bmrCalories">
        /// Basal Metabolic Rate calories - calories burned at rest.
        /// </param>
        /// <param name="calorieSamples">
        /// Array of calorie data samples recorded throughout the time period.
        /// </param>
        /// <param name="netActivityCalories">
        /// Net calories burned through activity (excluding BMR).
        /// </param>
        /// <param name="netIntakeCalories">
        /// Net calories consumed through food and drink intake.
        /// </param>
        /// <param name="totalBurnedCalories">
        /// Total calories burned including BMR and activity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaloriesData(
            double? bmrCalories,
            global::System.Collections.Generic.IList<global::Terra.CalorieSample>? calorieSamples,
            double? netActivityCalories,
            double? netIntakeCalories,
            double? totalBurnedCalories)
        {
            this.BmrCalories = bmrCalories;
            this.CalorieSamples = calorieSamples;
            this.NetActivityCalories = netActivityCalories;
            this.NetIntakeCalories = netIntakeCalories;
            this.TotalBurnedCalories = totalBurnedCalories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaloriesData" /> class.
        /// </summary>
        public CaloriesData()
        {
        }
    }
}