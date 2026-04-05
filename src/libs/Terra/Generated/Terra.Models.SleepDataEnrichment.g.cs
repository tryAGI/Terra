
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepDataEnrichment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_contributors")]
        public global::System.Collections.Generic.IList<global::Terra.DataContributor>? SleepContributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_score")]
        public double? SleepScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepDataEnrichment" /> class.
        /// </summary>
        /// <param name="sleepContributors"></param>
        /// <param name="sleepScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepDataEnrichment(
            global::System.Collections.Generic.IList<global::Terra.DataContributor>? sleepContributors,
            double? sleepScore)
        {
            this.SleepContributors = sleepContributors;
            this.SleepScore = sleepScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepDataEnrichment" /> class.
        /// </summary>
        public SleepDataEnrichment()
        {
        }
    }
}