
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartRateVariabilityDataSampleRMSSD
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// User's Heart Rate Variability, computed using RMSSD<br/>
        /// Example: 42.1
        /// </summary>
        /// <example>42.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv_rmssd")]
        public double? HrvRmssd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateVariabilityDataSampleRMSSD" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="hrvRmssd">
        /// User's Heart Rate Variability, computed using RMSSD<br/>
        /// Example: 42.1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartRateVariabilityDataSampleRMSSD(
            string? timestamp,
            double? hrvRmssd)
        {
            this.Timestamp = timestamp;
            this.HrvRmssd = hrvRmssd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateVariabilityDataSampleRMSSD" /> class.
        /// </summary>
        public HeartRateVariabilityDataSampleRMSSD()
        {
        }
    }
}