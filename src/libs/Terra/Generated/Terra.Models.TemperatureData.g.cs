
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemperatureData(
            global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? ambientTemperatureSamples,
            global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? bodyTemperatureSamples,
            global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? skinTemperatureSamples)
        {
            this.AmbientTemperatureSamples = ambientTemperatureSamples;
            this.BodyTemperatureSamples = bodyTemperatureSamples;
            this.SkinTemperatureSamples = skinTemperatureSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureData" /> class.
        /// </summary>
        public TemperatureData()
        {
        }
    }
}