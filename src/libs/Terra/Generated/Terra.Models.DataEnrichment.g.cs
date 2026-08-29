
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataEnrichment
    {
        /// <summary>
        /// Efficiency score for the workout.<br/>
        /// Example: 82
        /// </summary>
        /// <example>82</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("efficiency_score")]
        public double? EfficiencyScore { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the efficiency score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efficiency_contributors")]
        public global::Terra.RecordFloat? EfficiencyContributors { get; set; }

        /// <summary>
        /// Strain score for the workout.<br/>
        /// Example: 14.5
        /// </summary>
        /// <example>14.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain_score")]
        public double? StrainScore { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the strain score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain_contributors")]
        public global::Terra.RecordFloat? StrainContributors { get; set; }

        /// <summary>
        /// Recovery-corrected relative strain (RCRS) score for the workout.<br/>
        /// Example: 9
        /// </summary>
        /// <example>9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rcrs_score")]
        public double? RcrsScore { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the RCRS score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rcrs_contributors")]
        public global::Terra.RecordFloat? RcrsContributors { get; set; }

        /// <summary>
        /// Training impulse (TRIMP) score for the workout.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trimp_score")]
        public double? TrimpScore { get; set; }

        /// <summary>
        /// Map of contributing factor name to its weighted contribution to the TRIMP score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trimp_contributors")]
        public global::Terra.RecordFloat? TrimpContributors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEnrichment" /> class.
        /// </summary>
        /// <param name="efficiencyScore">
        /// Efficiency score for the workout.<br/>
        /// Example: 82
        /// </param>
        /// <param name="efficiencyContributors">
        /// Map of contributing factor name to its weighted contribution to the efficiency score.
        /// </param>
        /// <param name="strainScore">
        /// Strain score for the workout.<br/>
        /// Example: 14.5
        /// </param>
        /// <param name="strainContributors">
        /// Map of contributing factor name to its weighted contribution to the strain score.
        /// </param>
        /// <param name="rcrsScore">
        /// Recovery-corrected relative strain (RCRS) score for the workout.<br/>
        /// Example: 9
        /// </param>
        /// <param name="rcrsContributors">
        /// Map of contributing factor name to its weighted contribution to the RCRS score.
        /// </param>
        /// <param name="trimpScore">
        /// Training impulse (TRIMP) score for the workout.<br/>
        /// Example: 120
        /// </param>
        /// <param name="trimpContributors">
        /// Map of contributing factor name to its weighted contribution to the TRIMP score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataEnrichment(
            double? efficiencyScore,
            global::Terra.RecordFloat? efficiencyContributors,
            double? strainScore,
            global::Terra.RecordFloat? strainContributors,
            double? rcrsScore,
            global::Terra.RecordFloat? rcrsContributors,
            double? trimpScore,
            global::Terra.RecordFloat? trimpContributors)
        {
            this.EfficiencyScore = efficiencyScore;
            this.EfficiencyContributors = efficiencyContributors;
            this.StrainScore = strainScore;
            this.StrainContributors = strainContributors;
            this.RcrsScore = rcrsScore;
            this.RcrsContributors = rcrsContributors;
            this.TrimpScore = trimpScore;
            this.TrimpContributors = trimpContributors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEnrichment" /> class.
        /// </summary>
        public DataEnrichment()
        {
        }

    }
}