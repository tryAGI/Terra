
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TSSSample
    {
        /// <summary>
        /// Planned Training Stress Score value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned")]
        public double? Planned { get; set; }

        /// <summary>
        /// Actual Training Stress Score value achieved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual")]
        public double? Actual { get; set; }

        /// <summary>
        /// Method used to calculate the TSS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// Planned intensity factor for the training session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity_factor_planned")]
        public double? IntensityFactorPlanned { get; set; }

        /// <summary>
        /// Actual intensity factor achieved during the training session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity_factor_actual")]
        public double? IntensityFactorActual { get; set; }

        /// <summary>
        /// Normalized power output in watts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_power_watts")]
        public double? NormalizedPowerWatts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TSSSample" /> class.
        /// </summary>
        /// <param name="planned">
        /// Planned Training Stress Score value
        /// </param>
        /// <param name="actual">
        /// Actual Training Stress Score value achieved
        /// </param>
        /// <param name="method">
        /// Method used to calculate the TSS
        /// </param>
        /// <param name="intensityFactorPlanned">
        /// Planned intensity factor for the training session
        /// </param>
        /// <param name="intensityFactorActual">
        /// Actual intensity factor achieved during the training session
        /// </param>
        /// <param name="normalizedPowerWatts">
        /// Normalized power output in watts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TSSSample(
            double? planned,
            double? actual,
            string? method,
            double? intensityFactorPlanned,
            double? intensityFactorActual,
            double? normalizedPowerWatts)
        {
            this.Planned = planned;
            this.Actual = actual;
            this.Method = method;
            this.IntensityFactorPlanned = intensityFactorPlanned;
            this.IntensityFactorActual = intensityFactorActual;
            this.NormalizedPowerWatts = normalizedPowerWatts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TSSSample" /> class.
        /// </summary>
        public TSSSample()
        {
        }
    }
}