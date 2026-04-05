
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OxygenSaturationData
    {
        /// <summary>
        /// Average Oxygen Saturation percentage of the user during the sleep session.<br/>
        /// Example: 97
        /// </summary>
        /// <example>97</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_saturation_percentage")]
        public double? AvgSaturationPercentage { get; set; }

        /// <summary>
        /// The end time of the recording of oxygen saturation, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-24T08:00:00.000000+01:00
        /// </summary>
        /// <example>2022-11-24T08:00:00.000000+01:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Array of Oxygen Saturation percentage datapoints sampled throughout the sleep session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Terra.OxygenSaturationSample>? Samples { get; set; }

        /// <summary>
        /// The start time of the recording of oxygen saturation, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T22:00:00.000000+02:00
        /// </summary>
        /// <example>1999-11-23T22:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OxygenSaturationData" /> class.
        /// </summary>
        /// <param name="avgSaturationPercentage">
        /// Average Oxygen Saturation percentage of the user during the sleep session.<br/>
        /// Example: 97
        /// </param>
        /// <param name="endTime">
        /// The end time of the recording of oxygen saturation, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-24T08:00:00.000000+01:00
        /// </param>
        /// <param name="samples">
        /// Array of Oxygen Saturation percentage datapoints sampled throughout the sleep session.
        /// </param>
        /// <param name="startTime">
        /// The start time of the recording of oxygen saturation, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T22:00:00.000000+02:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OxygenSaturationData(
            double? avgSaturationPercentage,
            string? endTime,
            global::System.Collections.Generic.IList<global::Terra.OxygenSaturationSample>? samples,
            string? startTime)
        {
            this.AvgSaturationPercentage = avgSaturationPercentage;
            this.EndTime = endTime;
            this.Samples = samples;
            this.StartTime = startTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OxygenSaturationData" /> class.
        /// </summary>
        public OxygenSaturationData()
        {
        }
    }
}