
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyPatternSample
    {
        /// <summary>
        /// Hour of the day, represented as an integer from 0 to 23, where 0 is midnight and 23 is the hour before the next midnight.<br/>
        /// Example: 9
        /// </summary>
        /// <example>9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_from_midnight")]
        public int? TimeFromMidnight { get; set; }

        /// <summary>
        /// Percentile 5 of the glucose level at the given time of day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile_5")]
        public double? Percentile5 { get; set; }

        /// <summary>
        /// Percentile 25 of the glucose level at the given time of day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile_25")]
        public double? Percentile25 { get; set; }

        /// <summary>
        /// Percentile 50 of the glucose level at the given time of day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile_50")]
        public double? Percentile50 { get; set; }

        /// <summary>
        /// Percentile 75 of the glucose level at the given time of day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile_75")]
        public double? Percentile75 { get; set; }

        /// <summary>
        /// Percentile 95 of the glucose level at the given time of day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile_95")]
        public double? Percentile95 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyPatternSample" /> class.
        /// </summary>
        /// <param name="timeFromMidnight">
        /// Hour of the day, represented as an integer from 0 to 23, where 0 is midnight and 23 is the hour before the next midnight.<br/>
        /// Example: 9
        /// </param>
        /// <param name="percentile5">
        /// Percentile 5 of the glucose level at the given time of day.
        /// </param>
        /// <param name="percentile25">
        /// Percentile 25 of the glucose level at the given time of day.
        /// </param>
        /// <param name="percentile50">
        /// Percentile 50 of the glucose level at the given time of day.
        /// </param>
        /// <param name="percentile75">
        /// Percentile 75 of the glucose level at the given time of day.
        /// </param>
        /// <param name="percentile95">
        /// Percentile 95 of the glucose level at the given time of day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyPatternSample(
            int? timeFromMidnight,
            double? percentile5,
            double? percentile25,
            double? percentile50,
            double? percentile75,
            double? percentile95)
        {
            this.TimeFromMidnight = timeFromMidnight;
            this.Percentile5 = percentile5;
            this.Percentile25 = percentile25;
            this.Percentile50 = percentile50;
            this.Percentile75 = percentile75;
            this.Percentile95 = percentile95;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyPatternSample" /> class.
        /// </summary>
        public DailyPatternSample()
        {
        }

    }
}