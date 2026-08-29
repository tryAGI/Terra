
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Daily
    {
        /// <summary>
        /// Object containing information related to the time spent in different activity intensities during over the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_durations_data")]
        public global::Terra.ActiveDurationsData? ActiveDurationsData { get; set; }

        /// <summary>
        /// Object containing calorie-related information for the user during the specific day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories_data")]
        public global::Terra.CaloriesData? CaloriesData { get; set; }

        /// <summary>
        /// Object containing additional enrichment data for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_enrichment")]
        public global::Terra.DailyDataEnrichment2? DataEnrichment { get; set; }

        /// <summary>
        /// Object containing information on the device which recorded data for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_data")]
        public global::Terra.DeviceData? DeviceData { get; set; }

        /// <summary>
        /// Object containing information related to distance covered during the associated day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_data")]
        public global::Terra.DailyDistanceData2? DistanceData { get; set; }

        /// <summary>
        /// Object containing heartrate-related information for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_data")]
        public global::Terra.HeartRateData? HeartRateData { get; set; }

        /// <summary>
        /// Object containing information on the Metabolic Equivalent of Task for the day.
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
        /// Object containing information on oxygen-related metrics for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oxygen_data")]
        public global::Terra.OxygenData? OxygenData { get; set; }

        /// <summary>
        /// Scores for the user's performance on different metrics for the given day, as calculated by the fitness data provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::Terra.ScoresData? Scores { get; set; }

        /// <summary>
        /// Object containing information on the strain put on the user's body over a day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain_data")]
        public global::Terra.StrainData? StrainData { get; set; }

        /// <summary>
        /// Object containing information on the stress put on the user over a day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress_data")]
        public global::Terra.StressData? StressData { get; set; }

        /// <summary>
        /// Object containing all user-entered or automatically tagged events in the day.
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
        /// <param name="activeDurationsData">
        /// Object containing information related to the time spent in different activity intensities during over the day.
        /// </param>
        /// <param name="caloriesData">
        /// Object containing calorie-related information for the user during the specific day.
        /// </param>
        /// <param name="dataEnrichment">
        /// Object containing additional enrichment data for the day.
        /// </param>
        /// <param name="deviceData">
        /// Object containing information on the device which recorded data for the day.
        /// </param>
        /// <param name="distanceData">
        /// Object containing information related to distance covered during the associated day.
        /// </param>
        /// <param name="heartRateData">
        /// Object containing heartrate-related information for the day.
        /// </param>
        /// <param name="metData">
        /// Object containing information on the Metabolic Equivalent of Task for the day.
        /// </param>
        /// <param name="oxygenData">
        /// Object containing information on oxygen-related metrics for the day.
        /// </param>
        /// <param name="scores">
        /// Scores for the user's performance on different metrics for the given day, as calculated by the fitness data provider.
        /// </param>
        /// <param name="strainData">
        /// Object containing information on the strain put on the user's body over a day.
        /// </param>
        /// <param name="stressData">
        /// Object containing information on the stress put on the user over a day.
        /// </param>
        /// <param name="tagData">
        /// Object containing all user-entered or automatically tagged events in the day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Daily(
            global::Terra.DailyMetadata metadata,
            global::Terra.ActiveDurationsData? activeDurationsData,
            global::Terra.CaloriesData? caloriesData,
            global::Terra.DailyDataEnrichment2? dataEnrichment,
            global::Terra.DeviceData? deviceData,
            global::Terra.DailyDistanceData2? distanceData,
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