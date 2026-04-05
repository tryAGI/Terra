
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartRateDataDetailed
    {
        /// <summary>
        /// Array of HeartRate data samples recorded for the user during the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_samples")]
        public global::System.Collections.Generic.IList<global::Terra.HeartRateDataSample>? HrSamples { get; set; }

        /// <summary>
        /// Array of HeartRate Variability data samples recorded for the user during the workout, computed using RMSSD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv_samples_rmssd")]
        public global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleRMSSD>? HrvSamplesRmssd { get; set; }

        /// <summary>
        /// Array of HeartRate Variability data samples recorded for the user during the workout, computed using SDNN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hrv_samples_sdnn")]
        public global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleSDNN>? HrvSamplesSdnn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateDataDetailed" /> class.
        /// </summary>
        /// <param name="hrSamples">
        /// Array of HeartRate data samples recorded for the user during the workout.
        /// </param>
        /// <param name="hrvSamplesRmssd">
        /// Array of HeartRate Variability data samples recorded for the user during the workout, computed using RMSSD.
        /// </param>
        /// <param name="hrvSamplesSdnn">
        /// Array of HeartRate Variability data samples recorded for the user during the workout, computed using SDNN.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartRateDataDetailed(
            global::System.Collections.Generic.IList<global::Terra.HeartRateDataSample>? hrSamples,
            global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleRMSSD>? hrvSamplesRmssd,
            global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleSDNN>? hrvSamplesSdnn)
        {
            this.HrSamples = hrSamples;
            this.HrvSamplesRmssd = hrvSamplesRmssd;
            this.HrvSamplesSdnn = hrvSamplesSdnn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateDataDetailed" /> class.
        /// </summary>
        public HeartRateDataDetailed()
        {
        }
    }
}