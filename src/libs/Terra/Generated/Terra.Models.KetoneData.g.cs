
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KetoneData(
            global::System.Collections.Generic.IList<global::Terra.KetoneSample>? ketoneSamples)
        {
            this.KetoneSamples = ketoneSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KetoneData" /> class.
        /// </summary>
        public KetoneData()
        {
        }
    }
}