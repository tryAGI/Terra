
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartRateVariabilityDataSampleSDNN
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// User's Heart Rate Variability, computed using SDNN<br/>
        /// Example: 48.3
        /// </summary>
        /// <example>48.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv_sdnn")]
        public double? HrvSdnn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateVariabilityDataSampleSDNN" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="hrvSdnn">
        /// User's Heart Rate Variability, computed using SDNN<br/>
        /// Example: 48.3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartRateVariabilityDataSampleSDNN(
            string? timestamp,
            double? hrvSdnn)
        {
            this.Timestamp = timestamp;
            this.HrvSdnn = hrvSdnn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateVariabilityDataSampleSDNN" /> class.
        /// </summary>
        public HeartRateVariabilityDataSampleSDNN()
        {
        }
    }
}