
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HydrationMeasurementSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Total body water composition of the user, in kilograms.<br/>
        /// Example: 40
        /// </summary>
        /// <example>40</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hydration_kg")]
        public double? HydrationKg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HydrationMeasurementSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="hydrationKg">
        /// Total body water composition of the user, in kilograms.<br/>
        /// Example: 40
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HydrationMeasurementSample(
            string? timestamp,
            double? hydrationKg)
        {
            this.Timestamp = timestamp;
            this.HydrationKg = hydrationKg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HydrationMeasurementSample" /> class.
        /// </summary>
        public HydrationMeasurementSample()
        {
        }
    }
}