
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TSSData
    {
        /// <summary>
        /// Array of TSS information sampled throughout the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TSS_samples")]
        public global::System.Collections.Generic.IList<global::Terra.TSSSample>? TssSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TSSData" /> class.
        /// </summary>
        /// <param name="tssSamples">
        /// Array of TSS information sampled throughout the workout
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TSSData(
            global::System.Collections.Generic.IList<global::Terra.TSSSample>? tssSamples)
        {
            this.TssSamples = tssSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TSSData" /> class.
        /// </summary>
        public TSSData()
        {
        }
    }
}