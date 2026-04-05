
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HydrationData
    {
        /// <summary>
        /// User's total water consumption throughout the day.<br/>
        /// Example: 2500
        /// </summary>
        /// <example>2500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_total_water_consumption_ml")]
        public double? DayTotalWaterConsumptionMl { get; set; }

        /// <summary>
        /// User's hydration level samples throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hydration_amount_samples")]
        public global::System.Collections.Generic.IList<global::Terra.HydrationMeasurementSample>? HydrationAmountSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HydrationData" /> class.
        /// </summary>
        /// <param name="dayTotalWaterConsumptionMl">
        /// User's total water consumption throughout the day.<br/>
        /// Example: 2500
        /// </param>
        /// <param name="hydrationAmountSamples">
        /// User's hydration level samples throughout the day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HydrationData(
            double? dayTotalWaterConsumptionMl,
            global::System.Collections.Generic.IList<global::Terra.HydrationMeasurementSample>? hydrationAmountSamples)
        {
            this.DayTotalWaterConsumptionMl = dayTotalWaterConsumptionMl;
            this.HydrationAmountSamples = hydrationAmountSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HydrationData" /> class.
        /// </summary>
        public HydrationData()
        {
        }
    }
}