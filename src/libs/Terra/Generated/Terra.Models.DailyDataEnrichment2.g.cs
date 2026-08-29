
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DailyDataEnrichment2
    {
        /// <summary>
        /// Total stress score for the day.<br/>
        /// Example: 45
        /// </summary>
        /// <example>45</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_stress_score")]
        public double? TotalStressScore { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the stress score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress_contributors")]
        public global::Terra.RecordFloat? StressContributors { get; set; }

        /// <summary>
        /// Respiratory health score for the day.<br/>
        /// Example: 88
        /// </summary>
        /// <example>88</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("respiratory_score")]
        public double? RespiratoryScore { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the respiratory score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("respiratory_contributors")]
        public global::Terra.RecordFloat? RespiratoryContributors { get; set; }

        /// <summary>
        /// Immune system health index for the day.<br/>
        /// Example: 72
        /// </summary>
        /// <example>72</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("immune_index")]
        public int? ImmuneIndex { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the immune index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("immune_contributors")]
        public global::Terra.RecordFloat? ImmuneContributors { get; set; }

        /// <summary>
        /// Resilience score for the day.<br/>
        /// Example: 65
        /// </summary>
        /// <example>65</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resilience_score")]
        public int? ResilienceScore { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the resilience score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resilience_contributors")]
        public global::Terra.RecordFloat? ResilienceContributors { get; set; }

        /// <summary>
        /// Strain index for the day.<br/>
        /// Example: 12.5
        /// </summary>
        /// <example>12.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain_index")]
        public double? StrainIndex { get; set; }

        /// <summary>
        /// Categorical strain rating for the day (e.g. GREEN, AMBER, RED).<br/>
        /// Example: GREEN
        /// </summary>
        /// <example>GREEN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain_traffic_light")]
        public string? StrainTrafficLight { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the strain index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain_contributors")]
        public global::Terra.RecordFloat? StrainContributors { get; set; }

        /// <summary>
        /// Total stress score for the day, computed by the v2 model.<br/>
        /// Example: 43
        /// </summary>
        /// <example>43</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_stress_score_v2")]
        public double? TotalStressScoreV2 { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the v2 total stress score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_stress_score_v2_contributors")]
        public global::Terra.RecordFloat? TotalStressScoreV2Contributors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDataEnrichment2" /> class.
        /// </summary>
        /// <param name="totalStressScore">
        /// Total stress score for the day.<br/>
        /// Example: 45
        /// </param>
        /// <param name="stressContributors">
        /// Map of contributing factor name to its weighted contribution to the stress score.
        /// </param>
        /// <param name="respiratoryScore">
        /// Respiratory health score for the day.<br/>
        /// Example: 88
        /// </param>
        /// <param name="respiratoryContributors">
        /// Map of contributing factor name to its weighted contribution to the respiratory score.
        /// </param>
        /// <param name="immuneIndex">
        /// Immune system health index for the day.<br/>
        /// Example: 72
        /// </param>
        /// <param name="immuneContributors">
        /// Map of contributing factor name to its weighted contribution to the immune index.
        /// </param>
        /// <param name="resilienceScore">
        /// Resilience score for the day.<br/>
        /// Example: 65
        /// </param>
        /// <param name="resilienceContributors">
        /// Map of contributing factor name to its weighted contribution to the resilience score.
        /// </param>
        /// <param name="strainIndex">
        /// Strain index for the day.<br/>
        /// Example: 12.5
        /// </param>
        /// <param name="strainTrafficLight">
        /// Categorical strain rating for the day (e.g. GREEN, AMBER, RED).<br/>
        /// Example: GREEN
        /// </param>
        /// <param name="strainContributors">
        /// Map of contributing factor name to its weighted contribution to the strain index.
        /// </param>
        /// <param name="totalStressScoreV2">
        /// Total stress score for the day, computed by the v2 model.<br/>
        /// Example: 43
        /// </param>
        /// <param name="totalStressScoreV2Contributors">
        /// Map of contributing factor name to its weighted contribution to the v2 total stress score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyDataEnrichment2(
            double? totalStressScore,
            global::Terra.RecordFloat? stressContributors,
            double? respiratoryScore,
            global::Terra.RecordFloat? respiratoryContributors,
            int? immuneIndex,
            global::Terra.RecordFloat? immuneContributors,
            int? resilienceScore,
            global::Terra.RecordFloat? resilienceContributors,
            double? strainIndex,
            string? strainTrafficLight,
            global::Terra.RecordFloat? strainContributors,
            double? totalStressScoreV2,
            global::Terra.RecordFloat? totalStressScoreV2Contributors)
        {
            this.TotalStressScore = totalStressScore;
            this.StressContributors = stressContributors;
            this.RespiratoryScore = respiratoryScore;
            this.RespiratoryContributors = respiratoryContributors;
            this.ImmuneIndex = immuneIndex;
            this.ImmuneContributors = immuneContributors;
            this.ResilienceScore = resilienceScore;
            this.ResilienceContributors = resilienceContributors;
            this.StrainIndex = strainIndex;
            this.StrainTrafficLight = strainTrafficLight;
            this.StrainContributors = strainContributors;
            this.TotalStressScoreV2 = totalStressScoreV2;
            this.TotalStressScoreV2Contributors = totalStressScoreV2Contributors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDataEnrichment2" /> class.
        /// </summary>
        public DailyDataEnrichment2()
        {
        }

    }
}