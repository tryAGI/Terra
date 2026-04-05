
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeviceData
    {
        /// <summary>
        /// Activation timestamp of the device, if applicable.<br/>
        /// Example: 2022-12-25T00:00:00.000000+05:00
        /// </summary>
        /// <example>2022-12-25T00:00:00.000000+05:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activation_timestamp")]
        public string? ActivationTimestamp { get; set; }

        /// <summary>
        /// Data provided by the device, as enumerated types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_provided")]
        public global::System.Collections.Generic.IList<global::Terra.DeviceDataType>? DataProvided { get; set; }

        /// <summary>
        /// Hardware version of the device.<br/>
        /// Example: v2.1
        /// </summary>
        /// <example>v2.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware_version")]
        public string? HardwareVersion { get; set; }

        /// <summary>
        /// Last upload date from the device.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_upload_date")]
        public string? LastUploadDate { get; set; }

        /// <summary>
        /// Device manufacturer name.<br/>
        /// Example: Garmin
        /// </summary>
        /// <example>Garmin</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("manufacturer")]
        public string? Manufacturer { get; set; }

        /// <summary>
        /// Device name - note that this can also be the name of the application/package which the data comes from, if coming from a data aggregator such as Google Fit.<br/>
        /// Example: Forerunner 945
        /// </summary>
        /// <example>Forerunner 945</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Data pertaining to other devices which may have contributed data for this workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other_devices")]
        public global::System.Collections.Generic.IList<global::Terra.OtherDeviceData>? OtherDevices { get; set; }

        /// <summary>
        /// Sensor state of the device.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensor_state")]
        public string? SensorState { get; set; }

        /// <summary>
        /// Device Serial Number.<br/>
        /// Example: GR123456789
        /// </summary>
        /// <example>GR123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("serial_number")]
        public string? SerialNumber { get; set; }

        /// <summary>
        /// Device Software Version.<br/>
        /// Example: 5.2.1
        /// </summary>
        /// <example>5.2.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("software_version")]
        public string? SoftwareVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceData" /> class.
        /// </summary>
        /// <param name="activationTimestamp">
        /// Activation timestamp of the device, if applicable.<br/>
        /// Example: 2022-12-25T00:00:00.000000+05:00
        /// </param>
        /// <param name="dataProvided">
        /// Data provided by the device, as enumerated types.
        /// </param>
        /// <param name="hardwareVersion">
        /// Hardware version of the device.<br/>
        /// Example: v2.1
        /// </param>
        /// <param name="lastUploadDate">
        /// Last upload date from the device.
        /// </param>
        /// <param name="manufacturer">
        /// Device manufacturer name.<br/>
        /// Example: Garmin
        /// </param>
        /// <param name="name">
        /// Device name - note that this can also be the name of the application/package which the data comes from, if coming from a data aggregator such as Google Fit.<br/>
        /// Example: Forerunner 945
        /// </param>
        /// <param name="otherDevices">
        /// Data pertaining to other devices which may have contributed data for this workout.
        /// </param>
        /// <param name="sensorState">
        /// Sensor state of the device.
        /// </param>
        /// <param name="serialNumber">
        /// Device Serial Number.<br/>
        /// Example: GR123456789
        /// </param>
        /// <param name="softwareVersion">
        /// Device Software Version.<br/>
        /// Example: 5.2.1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeviceData(
            string? activationTimestamp,
            global::System.Collections.Generic.IList<global::Terra.DeviceDataType>? dataProvided,
            string? hardwareVersion,
            string? lastUploadDate,
            string? manufacturer,
            string? name,
            global::System.Collections.Generic.IList<global::Terra.OtherDeviceData>? otherDevices,
            string? sensorState,
            string? serialNumber,
            string? softwareVersion)
        {
            this.ActivationTimestamp = activationTimestamp;
            this.DataProvided = dataProvided;
            this.HardwareVersion = hardwareVersion;
            this.LastUploadDate = lastUploadDate;
            this.Manufacturer = manufacturer;
            this.Name = name;
            this.OtherDevices = otherDevices;
            this.SensorState = sensorState;
            this.SerialNumber = serialNumber;
            this.SoftwareVersion = softwareVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceData" /> class.
        /// </summary>
        public DeviceData()
        {
        }
    }
}