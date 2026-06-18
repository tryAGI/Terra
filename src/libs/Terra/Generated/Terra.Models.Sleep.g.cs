
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sleep
    {
        /// <summary>
        /// Object containing additional enrichment data for the sleep session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_enrichment")]
        public global::Terra.SleepDataEnrichment2? DataEnrichment { get; set; }

        /// <summary>
        /// Object containing information on the device which recorded data for the payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_data")]
        public global::Terra.DeviceData? DeviceData { get; set; }

        /// <summary>
        /// Object containing information on the user's heart rate during the sleep session.
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
        /// Object containing information on the user's readiness for the day, based off the quality and duration of their sleep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readiness_data")]
        public global::Terra.ReadinessData? ReadinessData { get; set; }

        /// <summary>
        /// Object containing information on the user's respiration throughout the sleep session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respiration_data")]
        public global::Terra.RespirationData? RespirationData { get; set; }

        /// <summary>
        /// User's sleep score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::Terra.SleepScores? Scores { get; set; }

        /// <summary>
        /// Object containing information on the user's duration spent in various sleep stages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_durations_data")]
        public global::Terra.SleepDurationsData? SleepDurationsData { get; set; }

        /// <summary>
        /// Object containing body temperature information of the user during the sleep recording session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_data")]
        public global::Terra.SleepTemperatureData2? TemperatureData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sleep" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="dataEnrichment">
        /// Object containing additional enrichment data for the sleep session.
        /// </param>
        /// <param name="deviceData">
        /// Object containing information on the device which recorded data for the payload.
        /// </param>
        /// <param name="heartRateData">
        /// Object containing information on the user's heart rate during the sleep session.
        /// </param>
        /// <param name="readinessData">
        /// Object containing information on the user's readiness for the day, based off the quality and duration of their sleep.
        /// </param>
        /// <param name="respirationData">
        /// Object containing information on the user's respiration throughout the sleep session.
        /// </param>
        /// <param name="scores">
        /// User's sleep score
        /// </param>
        /// <param name="sleepDurationsData">
        /// Object containing information on the user's duration spent in various sleep stages.
        /// </param>
        /// <param name="temperatureData">
        /// Object containing body temperature information of the user during the sleep recording session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sleep(
            global::Terra.SleepMetadata metadata,
            global::Terra.SleepDataEnrichment2? dataEnrichment,
            global::Terra.DeviceData? deviceData,
            global::Terra.HeartRateData? heartRateData,
            global::Terra.ReadinessData? readinessData,
            global::Terra.RespirationData? respirationData,
            global::Terra.SleepScores? scores,
            global::Terra.SleepDurationsData? sleepDurationsData,
            global::Terra.SleepTemperatureData2? temperatureData)
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