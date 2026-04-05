
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BreathsData
    {
        /// <summary>
        /// Average breathing rate of the user during the sleep session.<br/>
        /// Example: 14
        /// </summary>
        /// <example>14</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_breaths_per_min")]
        public double? AvgBreathsPerMin { get; set; }

        /// <summary>
        /// Maximum breathing rate of the user during the sleep session.<br/>
        /// Example: 18
        /// </summary>
        /// <example>18</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_breaths_per_min")]
        public double? MaxBreathsPerMin { get; set; }

        /// <summary>
        /// Minimum breathing rate of the user during the sleep session.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_breaths_per_min")]
        public double? MinBreathsPerMin { get; set; }

        /// <summary>
        /// Flag indicating if the reading was performed on demand, or if it was automatically captured by the device.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_demand_reading")]
        public bool? OnDemandReading { get; set; }

        /// <summary>
        /// List of breathing rate information sampled throughout the sleep session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::Terra.BreathSample>? Samples { get; set; }

        /// <summary>
        /// The start time of the recording of breathing rate data, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T22:00:00.000000+02:00
        /// </summary>
        /// <example>1999-11-23T22:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// The end time of the recording of breathing rate data, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-24T08:00:00.000000+01:00
        /// </summary>
        /// <example>2022-11-24T08:00:00.000000+01:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BreathsData" /> class.
        /// </summary>
        /// <param name="avgBreathsPerMin">
        /// Average breathing rate of the user during the sleep session.<br/>
        /// Example: 14
        /// </param>
        /// <param name="maxBreathsPerMin">
        /// Maximum breathing rate of the user during the sleep session.<br/>
        /// Example: 18
        /// </param>
        /// <param name="minBreathsPerMin">
        /// Minimum breathing rate of the user during the sleep session.<br/>
        /// Example: 10
        /// </param>
        /// <param name="onDemandReading">
        /// Flag indicating if the reading was performed on demand, or if it was automatically captured by the device.<br/>
        /// Example: false
        /// </param>
        /// <param name="samples">
        /// List of breathing rate information sampled throughout the sleep session.
        /// </param>
        /// <param name="startTime">
        /// The start time of the recording of breathing rate data, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T22:00:00.000000+02:00
        /// </param>
        /// <param name="endTime">
        /// The end time of the recording of breathing rate data, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-24T08:00:00.000000+01:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BreathsData(
            double? avgBreathsPerMin,
            double? maxBreathsPerMin,
            double? minBreathsPerMin,
            bool? onDemandReading,
            global::System.Collections.Generic.IList<global::Terra.BreathSample>? samples,
            string? startTime,
            string? endTime)
        {
            this.AvgBreathsPerMin = avgBreathsPerMin;
            this.MaxBreathsPerMin = maxBreathsPerMin;
            this.MinBreathsPerMin = minBreathsPerMin;
            this.OnDemandReading = onDemandReading;
            this.Samples = samples;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BreathsData" /> class.
        /// </summary>
        public BreathsData()
        {
        }
    }
}