
#nullable enable

namespace Terra
{
    /// <summary>
    /// User's sleep score
    /// </summary>
    public sealed partial class SleepScores
    {
        /// <summary>
        /// User's sleep score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep")]
        public double? Sleep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepScores" /> class.
        /// </summary>
        /// <param name="sleep">
        /// User's sleep score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepScores(
            double? sleep)
        {
            this.Sleep = sleep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepScores" /> class.
        /// </summary>
        public SleepScores()
        {
        }
    }
}