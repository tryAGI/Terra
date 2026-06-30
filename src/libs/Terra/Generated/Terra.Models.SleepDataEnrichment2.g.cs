
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepDataEnrichment2
    {
        /// <summary>
        /// Sleep score for the session.<br/>
        /// Example: 85
        /// </summary>
        /// <example>85</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_score")]
        public double? SleepScore { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the sleep score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_contributors")]
        public global::Terra.RecordFloat? SleepContributors { get; set; }

        /// <summary>
        /// Readiness score resulting from the sleep session.<br/>
        /// Example: 82
        /// </summary>
        /// <example>82</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("readiness_score")]
        public double? ReadinessScore { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the readiness score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readiness_contributors")]
        public global::Terra.RecordFloat? ReadinessContributors { get; set; }

        /// <summary>
        /// Sleep score for the session, computed by the v2 model.<br/>
        /// Example: 84
        /// </summary>
        /// <example>84</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_score_v2")]
        public double? SleepScoreV2 { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the v2 sleep score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_score_v2_contributors")]
        public global::Terra.RecordFloat? SleepScoreV2Contributors { get; set; }

        /// <summary>
        /// Respiratory score for the session, computed by the v2 model.<br/>
        /// Example: 90
        /// </summary>
        /// <example>90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("respiratory_score_v2")]
        public double? RespiratoryScoreV2 { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the v2 respiratory score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respiratory_score_v2_contributors")]
        public global::Terra.RecordFloat? RespiratoryScoreV2Contributors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepDataEnrichment2" /> class.
        /// </summary>
        /// <param name="sleepScore">
        /// Sleep score for the session.<br/>
        /// Example: 85
        /// </param>
        /// <param name="sleepContributors">
        /// Map of contributing factor name to its weighted contribution to the sleep score.
        /// </param>
        /// <param name="readinessScore">
        /// Readiness score resulting from the sleep session.<br/>
        /// Example: 82
        /// </param>
        /// <param name="readinessContributors">
        /// Map of contributing factor name to its weighted contribution to the readiness score.
        /// </param>
        /// <param name="sleepScoreV2">
        /// Sleep score for the session, computed by the v2 model.<br/>
        /// Example: 84
        /// </param>
        /// <param name="sleepScoreV2Contributors">
        /// Map of contributing factor name to its weighted contribution to the v2 sleep score.
        /// </param>
        /// <param name="respiratoryScoreV2">
        /// Respiratory score for the session, computed by the v2 model.<br/>
        /// Example: 90
        /// </param>
        /// <param name="respiratoryScoreV2Contributors">
        /// Map of contributing factor name to its weighted contribution to the v2 respiratory score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepDataEnrichment2(
            double? sleepScore,
            global::Terra.RecordFloat? sleepContributors,
            double? readinessScore,
            global::Terra.RecordFloat? readinessContributors,
            double? sleepScoreV2,
            global::Terra.RecordFloat? sleepScoreV2Contributors,
            double? respiratoryScoreV2,
            global::Terra.RecordFloat? respiratoryScoreV2Contributors)
        {
            this.SleepScore = sleepScore;
            this.SleepContributors = sleepContributors;
            this.ReadinessScore = readinessScore;
            this.ReadinessContributors = readinessContributors;
            this.SleepScoreV2 = sleepScoreV2;
            this.SleepScoreV2Contributors = sleepScoreV2Contributors;
            this.RespiratoryScoreV2 = respiratoryScoreV2;
            this.RespiratoryScoreV2Contributors = respiratoryScoreV2Contributors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepDataEnrichment2" /> class.
        /// </summary>
        public SleepDataEnrichment2()
        {
        }

    }
}