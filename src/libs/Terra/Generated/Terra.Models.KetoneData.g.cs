
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KetoneData
    {
        /// <summary>
        /// List of ketone data sampled through the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ketone_samples")]
        public global::System.Collections.Generic.IList<global::Terra.KetoneSample>? KetoneSamples { get; set; }

        /// <summary>
        /// Day-average ketone concentration, in mg/dL.<br/>
        /// Example: 1.2
        /// </summary>
        /// <example>1.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_ketone_mg_per_dL")]
        public double? DayAvgKetoneMgPerDL { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KetoneData" /> class.
        /// </summary>
        /// <param name="ketoneSamples">
        /// List of ketone data sampled through the day.
        /// </param>
        /// <param name="dayAvgKetoneMgPerDL">
        /// Day-average ketone concentration, in mg/dL.<br/>
        /// Example: 1.2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KetoneData(
            global::System.Collections.Generic.IList<global::Terra.KetoneSample>? ketoneSamples,
            double? dayAvgKetoneMgPerDL)
        {
            this.KetoneSamples = ketoneSamples;
            this.DayAvgKetoneMgPerDL = dayAvgKetoneMgPerDL;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KetoneData" /> class.
        /// </summary>
        public KetoneData()
        {
        }

    }
}