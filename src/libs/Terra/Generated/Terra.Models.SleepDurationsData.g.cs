
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepDurationsData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asleep")]
        public global::Terra.AsleepDurations? Asleep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awake")]
        public global::Terra.AwakeDurations? Awake { get; set; }

        /// <summary>
        /// List of sleep stage (Hypnogram) samples recorded during the user's sleep session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hypnogram_samples")]
        public global::System.Collections.Generic.IList<global::Terra.SleepHypnogramSample>? HypnogramSamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        public global::Terra.OtherSleepDurations? Other { get; set; }

        /// <summary>
        /// Sleep efficiency of the user given as a percentage, measured as time spent asleep divided by time spent in bed.<br/>
        /// Example: 87.5
        /// </summary>
        /// <example>87.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_efficiency")]
        public double? SleepEfficiency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepDurationsData" /> class.
        /// </summary>
        /// <param name="asleep"></param>
        /// <param name="awake"></param>
        /// <param name="hypnogramSamples">
        /// List of sleep stage (Hypnogram) samples recorded during the user's sleep session.
        /// </param>
        /// <param name="other"></param>
        /// <param name="sleepEfficiency">
        /// Sleep efficiency of the user given as a percentage, measured as time spent asleep divided by time spent in bed.<br/>
        /// Example: 87.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepDurationsData(
            global::Terra.AsleepDurations? asleep,
            global::Terra.AwakeDurations? awake,
            global::System.Collections.Generic.IList<global::Terra.SleepHypnogramSample>? hypnogramSamples,
            global::Terra.OtherSleepDurations? other,
            double? sleepEfficiency)
        {
            this.Asleep = asleep;
            this.Awake = awake;
            this.HypnogramSamples = hypnogramSamples;
            this.Other = other;
            this.SleepEfficiency = sleepEfficiency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepDurationsData" /> class.
        /// </summary>
        public SleepDurationsData()
        {
        }
    }
}