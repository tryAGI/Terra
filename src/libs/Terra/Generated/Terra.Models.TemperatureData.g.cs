
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemperatureData
    {
        /// <summary>
        /// List of ambient temperature measurements sampled throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ambient_temperature_samples")]
        public global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? AmbientTemperatureSamples { get; set; }

        /// <summary>
        /// List of body temperature measurements sampled throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_temperature_samples")]
        public global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? BodyTemperatureSamples { get; set; }

        /// <summary>
        /// List of skin temperature measurements sampled throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skin_temperature_samples")]
        public global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? SkinTemperatureSamples { get; set; }

        /// <summary>
        /// Day-average ambient temperature, in degrees Celsius.<br/>
        /// Example: 21.5
        /// </summary>
        /// <example>21.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_ambient_temperature_celsius")]
        public double? DayAvgAmbientTemperatureCelsius { get; set; }

        /// <summary>
        /// Day-average body temperature, in degrees Celsius.<br/>
        /// Example: 36.7
        /// </summary>
        /// <example>36.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_body_temperature_celsius")]
        public double? DayAvgBodyTemperatureCelsius { get; set; }

        /// <summary>
        /// Day-average skin temperature, in degrees Celsius.<br/>
        /// Example: 33.2
        /// </summary>
        /// <example>33.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_skin_temperature_celsius")]
        public double? DayAvgSkinTemperatureCelsius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureData" /> class.
        /// </summary>
        /// <param name="ambientTemperatureSamples">
        /// List of ambient temperature measurements sampled throughout the day.
        /// </param>
        /// <param name="bodyTemperatureSamples">
        /// List of body temperature measurements sampled throughout the day.
        /// </param>
        /// <param name="skinTemperatureSamples">
        /// List of skin temperature measurements sampled throughout the day.
        /// </param>
        /// <param name="dayAvgAmbientTemperatureCelsius">
        /// Day-average ambient temperature, in degrees Celsius.<br/>
        /// Example: 21.5
        /// </param>
        /// <param name="dayAvgBodyTemperatureCelsius">
        /// Day-average body temperature, in degrees Celsius.<br/>
        /// Example: 36.7
        /// </param>
        /// <param name="dayAvgSkinTemperatureCelsius">
        /// Day-average skin temperature, in degrees Celsius.<br/>
        /// Example: 33.2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemperatureData(
            global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? ambientTemperatureSamples,
            global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? bodyTemperatureSamples,
            global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? skinTemperatureSamples,
            double? dayAvgAmbientTemperatureCelsius,
            double? dayAvgBodyTemperatureCelsius,
            double? dayAvgSkinTemperatureCelsius)
        {
            this.AmbientTemperatureSamples = ambientTemperatureSamples;
            this.BodyTemperatureSamples = bodyTemperatureSamples;
            this.SkinTemperatureSamples = skinTemperatureSamples;
            this.DayAvgAmbientTemperatureCelsius = dayAvgAmbientTemperatureCelsius;
            this.DayAvgBodyTemperatureCelsius = dayAvgBodyTemperatureCelsius;
            this.DayAvgSkinTemperatureCelsius = dayAvgSkinTemperatureCelsius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureData" /> class.
        /// </summary>
        public TemperatureData()
        {
        }

    }
}