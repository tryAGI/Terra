
#nullable enable

namespace Terra
{
    /// <summary>
    /// Personal trend for one metric, computed by Terra from the user's own stored daily values. Both windows are trailing calendar-day windows that end the day BEFORE the record's own local day, so the record's value is never inside its own baseline. Statistics are absent (null) when the window has no data; the day counts say how much history stands behind each number.
    /// </summary>
    public sealed partial class MetricTrend
    {
        /// <summary>
        /// Median of the trailing window, in the metric's own units (bpm, ms, seconds).<br/>
        /// Example: 52
        /// </summary>
        /// <example>52</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline")]
        public double? Baseline { get; set; }

        /// <summary>
        /// Mean of the trailing window.<br/>
        /// Example: 53.5
        /// </summary>
        /// <example>53.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("average")]
        public double? Average { get; set; }

        /// <summary>
        /// Mean of the window immediately preceding the trailing window.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_average")]
        public double? PreviousAverage { get; set; }

        /// <summary>
        /// average minus previous_average. Present only when both averages are.<br/>
        /// Example: 3.5
        /// </summary>
        /// <example>3.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public double? Delta { get; set; }

        /// <summary>
        /// Number of days with data in the trailing window.<br/>
        /// Example: 28
        /// </summary>
        /// <example>28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("days_with_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DaysWithData { get; set; }

        /// <summary>
        /// Number of days with data in the preceding window.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_days_with_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PreviousDaysWithData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricTrend" /> class.
        /// </summary>
        /// <param name="daysWithData">
        /// Number of days with data in the trailing window.<br/>
        /// Example: 28
        /// </param>
        /// <param name="previousDaysWithData">
        /// Number of days with data in the preceding window.<br/>
        /// Example: 30
        /// </param>
        /// <param name="baseline">
        /// Median of the trailing window, in the metric's own units (bpm, ms, seconds).<br/>
        /// Example: 52
        /// </param>
        /// <param name="average">
        /// Mean of the trailing window.<br/>
        /// Example: 53.5
        /// </param>
        /// <param name="previousAverage">
        /// Mean of the window immediately preceding the trailing window.<br/>
        /// Example: 50
        /// </param>
        /// <param name="delta">
        /// average minus previous_average. Present only when both averages are.<br/>
        /// Example: 3.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricTrend(
            int daysWithData,
            int previousDaysWithData,
            double? baseline,
            double? average,
            double? previousAverage,
            double? delta)
        {
            this.Baseline = baseline;
            this.Average = average;
            this.PreviousAverage = previousAverage;
            this.Delta = delta;
            this.DaysWithData = daysWithData;
            this.PreviousDaysWithData = previousDaysWithData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricTrend" /> class.
        /// </summary>
        public MetricTrend()
        {
        }

    }
}