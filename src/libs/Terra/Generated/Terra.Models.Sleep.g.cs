
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sleep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_enrichment")]
        public global::Terra.SleepDataEnrichment? DataEnrichment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_data")]
        public global::Terra.DeviceData? DeviceData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_data")]
        public global::Terra.HeartRateData? HeartRateData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.SleepMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readiness_data")]
        public global::Terra.ReadinessData? ReadinessData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respiration_data")]
        public global::Terra.RespirationData? RespirationData { get; set; }

        /// <summary>
        /// User's sleep score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::Terra.SleepScores? Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_durations_data")]
        public global::Terra.SleepDurationsData? SleepDurationsData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_data")]
        public global::Terra.SleepTemperatureData? TemperatureData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleep" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="dataEnrichment"></param>
        /// <param name="deviceData"></param>
        /// <param name="heartRateData"></param>
        /// <param name="readinessData"></param>
        /// <param name="respirationData"></param>
        /// <param name="scores">
        /// User's sleep score
        /// </param>
        /// <param name="sleepDurationsData"></param>
        /// <param name="temperatureData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sleep(
            global::Terra.SleepMetadata metadata,
            global::Terra.SleepDataEnrichment? dataEnrichment,
            global::Terra.DeviceData? deviceData,
            global::Terra.HeartRateData? heartRateData,
            global::Terra.ReadinessData? readinessData,
            global::Terra.RespirationData? respirationData,
            global::Terra.SleepScores? scores,
            global::Terra.SleepDurationsData? sleepDurationsData,
            global::Terra.SleepTemperatureData? temperatureData)
        {
            this.DataEnrichment = dataEnrichment;
            this.DeviceData = deviceData;
            this.HeartRateData = heartRateData;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ReadinessData = readinessData;
            this.RespirationData = respirationData;
            this.Scores = scores;
            this.SleepDurationsData = sleepDurationsData;
            this.TemperatureData = temperatureData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleep" /> class.
        /// </summary>
        public Sleep()
        {
        }
    }
}