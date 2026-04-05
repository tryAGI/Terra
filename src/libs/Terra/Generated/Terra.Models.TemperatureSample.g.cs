
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemperatureSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Temperature value in degrees Celsius.<br/>
        /// Example: 37.2
        /// </summary>
        /// <example>37.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_celsius")]
        public double? TemperatureCelsius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="temperatureCelsius">
        /// Temperature value in degrees Celsius.<br/>
        /// Example: 37.2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemperatureSample(
            string? timestamp,
            double? temperatureCelsius)
        {
            this.Timestamp = timestamp;
            this.TemperatureCelsius = temperatureCelsius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureSample" /> class.
        /// </summary>
        public TemperatureSample()
        {
        }
    }
}