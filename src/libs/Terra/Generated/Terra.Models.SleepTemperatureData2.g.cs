
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SleepTemperatureData2
    {
        /// <summary>
        /// Variation in user's skin temperature from their baseline.<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public double? Delta { get; set; }

        /// <summary>
        /// Mean absolute skin temperature in degrees Celsius over the sleep window. Null for providers that only report a baseline deviation.<br/>
        /// Example: 33.7
        /// </summary>
        /// <example>33.7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_skin_temperature_celsius")]
        public double? AvgSkinTemperatureCelsius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepTemperatureData2" /> class.
        /// </summary>
        /// <param name="delta">
        /// Variation in user's skin temperature from their baseline.<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="avgSkinTemperatureCelsius">
        /// Mean absolute skin temperature in degrees Celsius over the sleep window. Null for providers that only report a baseline deviation.<br/>
        /// Example: 33.7
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepTemperatureData2(
            double? delta,
            double? avgSkinTemperatureCelsius)
        {
            this.Delta = delta;
            this.AvgSkinTemperatureCelsius = avgSkinTemperatureCelsius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepTemperatureData2" /> class.
        /// </summary>
        public SleepTemperatureData2()
        {
        }

    }
}