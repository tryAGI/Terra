
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlucoseDataSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// User's blood glucose reading<br/>
        /// Example: 95
        /// </summary>
        /// <example>95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blood_glucose_mg_per_dL")]
        public int? BloodGlucoseMgPerDL { get; set; }

        /// <summary>
        /// Flag indicating state of user's blood glucose level
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glucose_level_flag")]
        public double? GlucoseLevelFlag { get; set; }

        /// <summary>
        /// Flag indicating the current trend in the user's blood glucose level (e.g. rising, constant, falling)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trend_arrow")]
        public double? TrendArrow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlucoseDataSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="bloodGlucoseMgPerDL">
        /// User's blood glucose reading<br/>
        /// Example: 95
        /// </param>
        /// <param name="glucoseLevelFlag">
        /// Flag indicating state of user's blood glucose level
        /// </param>
        /// <param name="trendArrow">
        /// Flag indicating the current trend in the user's blood glucose level (e.g. rising, constant, falling)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlucoseDataSample(
            string? timestamp,
            int? bloodGlucoseMgPerDL,
            double? glucoseLevelFlag,
            double? trendArrow)
        {
            this.Timestamp = timestamp;
            this.BloodGlucoseMgPerDL = bloodGlucoseMgPerDL;
            this.GlucoseLevelFlag = glucoseLevelFlag;
            this.TrendArrow = trendArrow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlucoseDataSample" /> class.
        /// </summary>
        public GlucoseDataSample()
        {
        }
    }
}