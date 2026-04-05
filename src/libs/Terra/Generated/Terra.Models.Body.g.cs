
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Body
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blood_pressure_data")]
        public global::Terra.BloodPressureData? BloodPressureData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_data")]
        public global::Terra.DeviceData? DeviceData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_data")]
        public global::Terra.HeartData? HeartData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hydration_data")]
        public global::Terra.HydrationData? HydrationData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ketone_data")]
        public global::Terra.KetoneData? KetoneData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurements_data")]
        public global::Terra.MeasurementsData? MeasurementsData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.BodyMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oxygen_data")]
        public global::Terra.OxygenData? OxygenData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_data")]
        public global::Terra.TemperatureData? TemperatureData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glucose_data")]
        public global::Terra.GlucoseData? GlucoseData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="bloodPressureData"></param>
        /// <param name="deviceData"></param>
        /// <param name="heartData"></param>
        /// <param name="hydrationData"></param>
        /// <param name="ketoneData"></param>
        /// <param name="measurementsData"></param>
        /// <param name="oxygenData"></param>
        /// <param name="temperatureData"></param>
        /// <param name="glucoseData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Body(
            global::Terra.BodyMetadata metadata,
            global::Terra.BloodPressureData? bloodPressureData,
            global::Terra.DeviceData? deviceData,
            global::Terra.HeartData? heartData,
            global::Terra.HydrationData? hydrationData,
            global::Terra.KetoneData? ketoneData,
            global::Terra.MeasurementsData? measurementsData,
            global::Terra.OxygenData? oxygenData,
            global::Terra.TemperatureData? temperatureData,
            global::Terra.GlucoseData? glucoseData)
        {
            this.BloodPressureData = bloodPressureData;
            this.DeviceData = deviceData;
            this.HeartData = heartData;
            this.HydrationData = hydrationData;
            this.KetoneData = ketoneData;
            this.MeasurementsData = measurementsData;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.OxygenData = oxygenData;
            this.TemperatureData = temperatureData;
            this.GlucoseData = glucoseData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        public Body()
        {
        }
    }
}