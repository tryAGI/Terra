
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SleepScores2
    {
        /// <summary>
        /// User's sleep score for the session.<br/>
        /// Example: 85
        /// </summary>
        /// <example>85</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep")]
        public double? Sleep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepScores2" /> class.
        /// </summary>
        /// <param name="sleep">
        /// User's sleep score for the session.<br/>
        /// Example: 85
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepScores2(
            double? sleep)
        {
            this.Sleep = sleep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepScores2" /> class.
        /// </summary>
        public SleepScores2()
        {
        }

    }
}