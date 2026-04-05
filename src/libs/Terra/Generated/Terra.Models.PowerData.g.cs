
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowerData
    {
        /// <summary>
        /// Average power output of the user during the workout.<br/>
        /// Example: 185
        /// </summary>
        /// <example>185</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_watts")]
        public double? AvgWatts { get; set; }

        /// <summary>
        /// Maximum power output of the user during the workout.<br/>
        /// Example: 350
        /// </summary>
        /// <example>350</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_watts")]
        public double? MaxWatts { get; set; }

        /// <summary>
        /// Array containing datapoints of the power output of the user sampled throughout the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_samples")]
        public global::System.Collections.Generic.IList<global::Terra.PowerSample>? PowerSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerData" /> class.
        /// </summary>
        /// <param name="avgWatts">
        /// Average power output of the user during the workout.<br/>
        /// Example: 185
        /// </param>
        /// <param name="maxWatts">
        /// Maximum power output of the user during the workout.<br/>
        /// Example: 350
        /// </param>
        /// <param name="powerSamples">
        /// Array containing datapoints of the power output of the user sampled throughout the workout.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PowerData(
            double? avgWatts,
            double? maxWatts,
            global::System.Collections.Generic.IList<global::Terra.PowerSample>? powerSamples)
        {
            this.AvgWatts = avgWatts;
            this.MaxWatts = maxWatts;
            this.PowerSamples = powerSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerData" /> class.
        /// </summary>
        public PowerData()
        {
        }
    }
}