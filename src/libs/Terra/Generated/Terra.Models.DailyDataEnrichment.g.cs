
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyDataEnrichment
    {
        /// <summary>
        /// Array of factors contributing to cardiovascular score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardiovascular_contributors")]
        public global::System.Collections.Generic.IList<global::Terra.DataContributor>? CardiovascularContributors { get; set; }

        /// <summary>
        /// Cardiovascular health score for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardiovascular_score")]
        public double? CardiovascularScore { get; set; }

        /// <summary>
        /// Array of factors contributing to immune index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("immune_contributors")]
        public global::System.Collections.Generic.IList<global::Terra.DataContributor>? ImmuneContributors { get; set; }

        /// <summary>
        /// Immune system health index for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("immune_index")]
        public double? ImmuneIndex { get; set; }

        /// <summary>
        /// Array of factors contributing to readiness score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readiness_contributors")]
        public global::System.Collections.Generic.IList<global::Terra.DataContributor>? ReadinessContributors { get; set; }

        /// <summary>
        /// Readiness score for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readiness_score")]
        public double? ReadinessScore { get; set; }

        /// <summary>
        /// Array of factors contributing to respiratory score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respiratory_contributors")]
        public global::System.Collections.Generic.IList<global::Terra.DataContributor>? RespiratoryContributors { get; set; }

        /// <summary>
        /// Respiratory health score for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respiratory_score")]
        public double? RespiratoryScore { get; set; }

        /// <summary>
        /// Start time for the data enrichment calculation period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Array of factors contributing to stress score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress_contributors")]
        public global::System.Collections.Generic.IList<global::Terra.DataContributor>? StressContributors { get; set; }

        /// <summary>
        /// Total stress score for the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_stress_score")]
        public double? TotalStressScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDataEnrichment" /> class.
        /// </summary>
        /// <param name="cardiovascularContributors">
        /// Array of factors contributing to cardiovascular score.
        /// </param>
        /// <param name="cardiovascularScore">
        /// Cardiovascular health score for the day.
        /// </param>
        /// <param name="immuneContributors">
        /// Array of factors contributing to immune index.
        /// </param>
        /// <param name="immuneIndex">
        /// Immune system health index for the day.
        /// </param>
        /// <param name="readinessContributors">
        /// Array of factors contributing to readiness score.
        /// </param>
        /// <param name="readinessScore">
        /// Readiness score for the day.
        /// </param>
        /// <param name="respiratoryContributors">
        /// Array of factors contributing to respiratory score.
        /// </param>
        /// <param name="respiratoryScore">
        /// Respiratory health score for the day.
        /// </param>
        /// <param name="startTime">
        /// Start time for the data enrichment calculation period.
        /// </param>
        /// <param name="stressContributors">
        /// Array of factors contributing to stress score.
        /// </param>
        /// <param name="totalStressScore">
        /// Total stress score for the day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyDataEnrichment(
            global::System.Collections.Generic.IList<global::Terra.DataContributor>? cardiovascularContributors,
            double? cardiovascularScore,
            global::System.Collections.Generic.IList<global::Terra.DataContributor>? immuneContributors,
            double? immuneIndex,
            global::System.Collections.Generic.IList<global::Terra.DataContributor>? readinessContributors,
            double? readinessScore,
            global::System.Collections.Generic.IList<global::Terra.DataContributor>? respiratoryContributors,
            double? respiratoryScore,
            string? startTime,
            global::System.Collections.Generic.IList<global::Terra.DataContributor>? stressContributors,
            double? totalStressScore)
        {
            this.CardiovascularContributors = cardiovascularContributors;
            this.CardiovascularScore = cardiovascularScore;
            this.ImmuneContributors = immuneContributors;
            this.ImmuneIndex = immuneIndex;
            this.ReadinessContributors = readinessContributors;
            this.ReadinessScore = readinessScore;
            this.RespiratoryContributors = respiratoryContributors;
            this.RespiratoryScore = respiratoryScore;
            this.StartTime = startTime;
            this.StressContributors = stressContributors;
            this.TotalStressScore = totalStressScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDataEnrichment" /> class.
        /// </summary>
        public DailyDataEnrichment()
        {
        }
    }
}