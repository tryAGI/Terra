
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataContributor
    {
        /// <summary>
        /// Name of the factor contributing to the score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributor_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContributorName { get; set; }

        /// <summary>
        /// Numerical score representing the contribution of this factor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributor_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ContributorScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataContributor" /> class.
        /// </summary>
        /// <param name="contributorName">
        /// Name of the factor contributing to the score.
        /// </param>
        /// <param name="contributorScore">
        /// Numerical score representing the contribution of this factor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataContributor(
            string contributorName,
            double contributorScore)
        {
            this.ContributorName = contributorName ?? throw new global::System.ArgumentNullException(nameof(contributorName));
            this.ContributorScore = contributorScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataContributor" /> class.
        /// </summary>
        public DataContributor()
        {
        }
    }
}