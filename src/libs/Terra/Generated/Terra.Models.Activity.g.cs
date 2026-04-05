
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Activity
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
        /// Cheat detection flag.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cheat_detection")]
        public double? CheatDetection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_enrichment")]
        public global::Terra.DataEnrichment? DataEnrichment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_data")]
        public global::Terra.DeviceData? DeviceData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_data")]
        public global::Terra.DistanceData? DistanceData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("energy_data")]
        public global::Terra.EnergyData? EnergyData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_data")]
        public global::Terra.HeartRateData? HeartRateData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lap_data")]
        public global::Terra.LapData? LapData { get; set; }

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
        public required global::Terra.ActivityMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("movement_data")]
        public global::Terra.MovementData? MovementData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oxygen_data")]
        public global::Terra.OxygenData? OxygenData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polyline_map_data")]
        public global::Terra.PolylineMapData? PolylineMapData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_data")]
        public global::Terra.PositionData? PositionData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_data")]
        public global::Terra.PowerData? PowerData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain_data")]
        public global::Terra.StrainData? StrainData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TSS_data")]
        public global::Terra.TSSData? TssData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("work_data")]
        public global::Terra.WorkData? WorkData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="activeDurationsData"></param>
        /// <param name="caloriesData"></param>
        /// <param name="cheatDetection">
        /// Cheat detection flag.<br/>
        /// Example: 0
        /// </param>
        /// <param name="dataEnrichment"></param>
        /// <param name="deviceData"></param>
        /// <param name="distanceData"></param>
        /// <param name="energyData"></param>
        /// <param name="heartRateData"></param>
        /// <param name="lapData"></param>
        /// <param name="metData"></param>
        /// <param name="movementData"></param>
        /// <param name="oxygenData"></param>
        /// <param name="polylineMapData"></param>
        /// <param name="positionData"></param>
        /// <param name="powerData"></param>
        /// <param name="strainData"></param>
        /// <param name="tssData"></param>
        /// <param name="workData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Activity(
            global::Terra.ActivityMetadata metadata,
            global::Terra.ActiveDurationsData? activeDurationsData,
            global::Terra.CaloriesData? caloriesData,
            double? cheatDetection,
            global::Terra.DataEnrichment? dataEnrichment,
            global::Terra.DeviceData? deviceData,
            global::Terra.DistanceData? distanceData,
            global::Terra.EnergyData? energyData,
            global::Terra.HeartRateData? heartRateData,
            global::Terra.LapData? lapData,
            global::Terra.METData? metData,
            global::Terra.MovementData? movementData,
            global::Terra.OxygenData? oxygenData,
            global::Terra.PolylineMapData? polylineMapData,
            global::Terra.PositionData? positionData,
            global::Terra.PowerData? powerData,
            global::Terra.StrainData? strainData,
            global::Terra.TSSData? tssData,
            global::Terra.WorkData? workData)
        {
            this.ActiveDurationsData = activeDurationsData;
            this.CaloriesData = caloriesData;
            this.CheatDetection = cheatDetection;
            this.DataEnrichment = dataEnrichment;
            this.DeviceData = deviceData;
            this.DistanceData = distanceData;
            this.EnergyData = energyData;
            this.HeartRateData = heartRateData;
            this.LapData = lapData;
            this.MetData = metData;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.MovementData = movementData;
            this.OxygenData = oxygenData;
            this.PolylineMapData = polylineMapData;
            this.PositionData = positionData;
            this.PowerData = powerData;
            this.StrainData = strainData;
            this.TssData = tssData;
            this.WorkData = workData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        public Activity()
        {
        }
    }
}