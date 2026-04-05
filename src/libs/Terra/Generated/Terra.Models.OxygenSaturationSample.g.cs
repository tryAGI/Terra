
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OxygenSaturationSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// User's oxygen saturation percentage - referring to either SpO2 or SmO2, based on the `type` field<br/>
        /// Example: 98
        /// </summary>
        /// <example>98</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        public double? Percentage { get; set; }

        /// <summary>
        /// Type of oxygen saturation measurement (i.e. blood vs muscle)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public double? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OxygenSaturationSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="percentage">
        /// User's oxygen saturation percentage - referring to either SpO2 or SmO2, based on the `type` field<br/>
        /// Example: 98
        /// </param>
        /// <param name="type">
        /// Type of oxygen saturation measurement (i.e. blood vs muscle)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OxygenSaturationSample(
            string? timestamp,
            double? percentage,
            double? type)
        {
            this.Timestamp = timestamp;
            this.Percentage = percentage;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OxygenSaturationSample" /> class.
        /// </summary>
        public OxygenSaturationSample()
        {
        }
    }
}