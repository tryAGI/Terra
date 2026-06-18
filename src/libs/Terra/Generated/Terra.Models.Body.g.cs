
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Body
    {
        /// <summary>
        /// Object containing information on user's Blood Pressure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blood_pressure_data")]
        public global::Terra.BloodPressureData? BloodPressureData { get; set; }

        /// <summary>
        /// Object containing information on the device which recorded data for the payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_data")]
        public global::Terra.DeviceData? DeviceData { get; set; }

        /// <summary>
        /// Object containing information on user's heart metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_data")]
        public global::Terra.HeartData? HeartData { get; set; }

        /// <summary>
        /// Object containing information on user's hydration (both internal &amp; consumption of water) for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hydration_data")]
        public global::Terra.HydrationData? HydrationData { get; set; }

        /// <summary>
        /// Object containing information on user's ketone data for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ketone_data")]
        public global::Terra.KetoneData? KetoneData { get; set; }

        /// <summary>
        /// Object containing information on body measurements for the day.
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
        /// Object containing information on user's oxygen-related data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oxygen_data")]
        public global::Terra.OxygenData? OxygenData { get; set; }

        /// <summary>
        /// Object containing temperature information (core, skin, ambient) during the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_data")]
        public global::Terra.TemperatureData? TemperatureData { get; set; }

        /// <summary>
        /// Object containing information on user's blood glucose for the day.
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
        /// <param name="bloodPressureData">
        /// Object containing information on user's Blood Pressure.
        /// </param>
        /// <param name="deviceData">
        /// Object containing information on the device which recorded data for the payload.
        /// </param>
        /// <param name="heartData">
        /// Object containing information on user's heart metrics.
        /// </param>
        /// <param name="hydrationData">
        /// Object containing information on user's hydration (both internal &amp; consumption of water) for the day.
        /// </param>
        /// <param name="ketoneData">
        /// Object containing information on user's ketone data for the day.
        /// </param>
        /// <param name="measurementsData">
        /// Object containing information on body measurements for the day.
        /// </param>
        /// <param name="oxygenData">
        /// Object containing information on user's oxygen-related data.
        /// </param>
        /// <param name="temperatureData">
        /// Object containing temperature information (core, skin, ambient) during the day.
        /// </param>
        /// <param name="glucoseData">
        /// Object containing information on user's blood glucose for the day.
        /// </param>
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