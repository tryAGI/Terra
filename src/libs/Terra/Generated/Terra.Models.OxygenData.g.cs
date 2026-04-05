
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OxygenData
    {
        /// <summary>
        /// Average Oxygen Saturation percentage of the user during the day (SpO2 or SmO2).<br/>
        /// Example: 98
        /// </summary>
        /// <example>98</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_saturation_percentage")]
        public double? AvgSaturationPercentage { get; set; }

        /// <summary>
        /// Array of Oxygen Saturation percentage datapoints sampled throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saturation_samples")]
        public global::System.Collections.Generic.IList<global::Terra.OxygenSaturationSample>? SaturationSamples { get; set; }

        /// <summary>
        /// Array of VO2 datapoints sampled throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vo2_samples")]
        public global::System.Collections.Generic.IList<global::Terra.Vo2MaxSample>? Vo2Samples { get; set; }

        /// <summary>
        /// VO2Max for the given user.<br/>
        /// Example: 45.5
        /// </summary>
        /// <example>45.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vo2max_ml_per_min_per_kg")]
        public double? Vo2maxMlPerMinPerKg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OxygenData" /> class.
        /// </summary>
        /// <param name="avgSaturationPercentage">
        /// Average Oxygen Saturation percentage of the user during the day (SpO2 or SmO2).<br/>
        /// Example: 98
        /// </param>
        /// <param name="saturationSamples">
        /// Array of Oxygen Saturation percentage datapoints sampled throughout the day.
        /// </param>
        /// <param name="vo2Samples">
        /// Array of VO2 datapoints sampled throughout the day.
        /// </param>
        /// <param name="vo2maxMlPerMinPerKg">
        /// VO2Max for the given user.<br/>
        /// Example: 45.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OxygenData(
            double? avgSaturationPercentage,
            global::System.Collections.Generic.IList<global::Terra.OxygenSaturationSample>? saturationSamples,
            global::System.Collections.Generic.IList<global::Terra.Vo2MaxSample>? vo2Samples,
            double? vo2maxMlPerMinPerKg)
        {
            this.AvgSaturationPercentage = avgSaturationPercentage;
            this.SaturationSamples = saturationSamples;
            this.Vo2Samples = vo2Samples;
            this.Vo2maxMlPerMinPerKg = vo2maxMlPerMinPerKg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OxygenData" /> class.
        /// </summary>
        public OxygenData()
        {
        }
    }
}