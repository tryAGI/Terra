
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Daily
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_durations_data")]
        public global::Terra.ActiveDurationsData? ActiveDurationsData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories_data")]
        public global::Terra.CaloriesData? CaloriesData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_enrichment")]
        public global::Terra.DailyDataEnrichment? DataEnrichment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_data")]
        public global::Terra.DeviceData? DeviceData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_data")]
        public global::Terra.DailyDistanceData? DistanceData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_data")]
        public global::Terra.HeartRateData? HeartRateData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MET_data")]
        public global::Terra.METData? MetData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.DailyMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oxygen_data")]
        public global::Terra.OxygenData? OxygenData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::Terra.ScoresData? Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain_data")]
        public global::Terra.StrainData? StrainData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress_data")]
        public global::Terra.StressData? StressData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_data")]
        public global::Terra.TagData? TagData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Daily" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="activeDurationsData"></param>
        /// <param name="caloriesData"></param>
        /// <param name="dataEnrichment"></param>
        /// <param name="deviceData"></param>
        /// <param name="distanceData"></param>
        /// <param name="heartRateData"></param>
        /// <param name="metData"></param>
        /// <param name="oxygenData"></param>
        /// <param name="scores"></param>
        /// <param name="strainData"></param>
        /// <param name="stressData"></param>
        /// <param name="tagData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Daily(
            global::Terra.DailyMetadata metadata,
            global::Terra.ActiveDurationsData? activeDurationsData,
            global::Terra.CaloriesData? caloriesData,
            global::Terra.DailyDataEnrichment? dataEnrichment,
            global::Terra.DeviceData? deviceData,
            global::Terra.DailyDistanceData? distanceData,
            global::Terra.HeartRateData? heartRateData,
            global::Terra.METData? metData,
            global::Terra.OxygenData? oxygenData,
            global::Terra.ScoresData? scores,
            global::Terra.StrainData? strainData,
            global::Terra.StressData? stressData,
            global::Terra.TagData? tagData)
        {
            this.ActiveDurationsData = activeDurationsData;
            this.CaloriesData = caloriesData;
            this.DataEnrichment = dataEnrichment;
            this.DeviceData = deviceData;
            this.DistanceData = distanceData;
            this.HeartRateData = heartRateData;
            this.MetData = metData;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.OxygenData = oxygenData;
            this.Scores = scores;
            this.StrainData = strainData;
            this.StressData = stressData;
            this.TagData = tagData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Daily" /> class.
        /// </summary>
        public Daily()
        {
        }
    }
}