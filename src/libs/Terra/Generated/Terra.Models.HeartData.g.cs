
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartData
    {
        /// <summary>
        /// List of Atrial Fibrillation classification measurements sampled through the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afib_classification_samples")]
        public global::System.Collections.Generic.IList<global::Terra.AFibClassificationSample>? AfibClassificationSamples { get; set; }

        /// <summary>
        /// List of ECGReadings sampled through the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ecg_signal")]
        public global::System.Collections.Generic.IList<global::Terra.ECGReading>? EcgSignal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_data")]
        public global::Terra.HeartRateData? HeartRateData { get; set; }

        /// <summary>
        /// List of Pulse Wave Velocity measurements sampled throughout the day. This represents a measurement of arterial stiffness that is an independent predictor of cardiovascular risk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulse_wave_velocity_samples")]
        public global::System.Collections.Generic.IList<global::Terra.PulseVelocitySample>? PulseWaveVelocitySamples { get; set; }

        /// <summary>
        /// List of RR Interval samples throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rr_interval_samples")]
        public global::System.Collections.Generic.IList<global::Terra.RRIntervalSample>? RrIntervalSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartData" /> class.
        /// </summary>
        /// <param name="afibClassificationSamples">
        /// List of Atrial Fibrillation classification measurements sampled through the day.
        /// </param>
        /// <param name="ecgSignal">
        /// List of ECGReadings sampled through the day.
        /// </param>
        /// <param name="heartRateData"></param>
        /// <param name="pulseWaveVelocitySamples">
        /// List of Pulse Wave Velocity measurements sampled throughout the day. This represents a measurement of arterial stiffness that is an independent predictor of cardiovascular risk.
        /// </param>
        /// <param name="rrIntervalSamples">
        /// List of RR Interval samples throughout the day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartData(
            global::System.Collections.Generic.IList<global::Terra.AFibClassificationSample>? afibClassificationSamples,
            global::System.Collections.Generic.IList<global::Terra.ECGReading>? ecgSignal,
            global::Terra.HeartRateData? heartRateData,
            global::System.Collections.Generic.IList<global::Terra.PulseVelocitySample>? pulseWaveVelocitySamples,
            global::System.Collections.Generic.IList<global::Terra.RRIntervalSample>? rrIntervalSamples)
        {
            this.AfibClassificationSamples = afibClassificationSamples;
            this.EcgSignal = ecgSignal;
            this.HeartRateData = heartRateData;
            this.PulseWaveVelocitySamples = pulseWaveVelocitySamples;
            this.RrIntervalSamples = rrIntervalSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartData" /> class.
        /// </summary>
        public HeartData()
        {
        }
    }
}