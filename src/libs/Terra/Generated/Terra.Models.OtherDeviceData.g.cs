
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtherDeviceData
    {
        /// <summary>
        /// Device manufacturer name.<br/>
        /// Example: Garmin
        /// </summary>
        /// <example>Garmin</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("manufacturer")]
        public string? Manufacturer { get; set; }

        /// <summary>
        /// Hardware version of the device.<br/>
        /// Example: v2.1
        /// </summary>
        /// <example>v2.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware_version")]
        public string? HardwareVersion { get; set; }

        /// <summary>
        /// Device Serial Number.<br/>
        /// Example: GR123456789
        /// </summary>
        /// <example>GR123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("serial_number")]
        public string? SerialNumber { get; set; }

        /// <summary>
        /// Device name - note that this can also be the name of the application/package which the data comes from, if coming from a data aggregator such as Google Fit.<br/>
        /// Example: Forerunner 945
        /// </summary>
        /// <example>Forerunner 945</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Device Software Version.<br/>
        /// Example: 5.2.1
        /// </summary>
        /// <example>5.2.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("software_version")]
        public string? SoftwareVersion { get; set; }

        /// <summary>
        /// Activation timestamp of the device, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activation_timestamp")]
        public string? ActivationTimestamp { get; set; }

        /// <summary>
        /// Data provided by the device, as enumerated types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_provided")]
        public global::System.Collections.Generic.IList<global::Terra.DeviceDataType>? DataProvided { get; set; }

        /// <summary>
        /// Last upload date from the device.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_upload_date")]
        public string? LastUploadDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherDeviceData" /> class.
        /// </summary>
        /// <param name="manufacturer">
        /// Device manufacturer name.<br/>
        /// Example: Garmin
        /// </param>
        /// <param name="hardwareVersion">
        /// Hardware version of the device.<br/>
        /// Example: v2.1
        /// </param>
        /// <param name="serialNumber">
        /// Device Serial Number.<br/>
        /// Example: GR123456789
        /// </param>
        /// <param name="name">
        /// Device name - note that this can also be the name of the application/package which the data comes from, if coming from a data aggregator such as Google Fit.<br/>
        /// Example: Forerunner 945
        /// </param>
        /// <param name="softwareVersion">
        /// Device Software Version.<br/>
        /// Example: 5.2.1
        /// </param>
        /// <param name="activationTimestamp">
        /// Activation timestamp of the device, if applicable.
        /// </param>
        /// <param name="dataProvided">
        /// Data provided by the device, as enumerated types.
        /// </param>
        /// <param name="lastUploadDate">
        /// Last upload date from the device.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtherDeviceData(
            string? manufacturer,
            string? hardwareVersion,
            string? serialNumber,
            string? name,
            string? softwareVersion,
            string? activationTimestamp,
            global::System.Collections.Generic.IList<global::Terra.DeviceDataType>? dataProvided,
            string? lastUploadDate)
        {
            this.Manufacturer = manufacturer;
            this.HardwareVersion = hardwareVersion;
            this.SerialNumber = serialNumber;
            this.Name = name;
            this.SoftwareVersion = softwareVersion;
            this.ActivationTimestamp = activationTimestamp;
            this.DataProvided = dataProvided;
            this.LastUploadDate = lastUploadDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherDeviceData" /> class.
        /// </summary>
        public OtherDeviceData()
        {
        }
    }
}