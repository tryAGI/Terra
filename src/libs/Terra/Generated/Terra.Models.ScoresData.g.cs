
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoresData
    {
        /// <summary>
        /// Activity score for the given day.<br/>
        /// Example: 92
        /// </summary>
        /// <example>92</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public double? Activity { get; set; }

        /// <summary>
        /// Recovery score for the given day.<br/>
        /// Example: 78
        /// </summary>
        /// <example>78</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery")]
        public double? Recovery { get; set; }

        /// <summary>
        /// Sleep score for the given day, pertaining to the previous night's sleep.<br/>
        /// Example: 85
        /// </summary>
        /// <example>85</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep")]
        public double? Sleep { get; set; }

        /// <summary>
        /// Biological age computed for the given day.<br/>
        /// Example: 27
        /// </summary>
        /// <example>27</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("biological_age")]
        public double? BiologicalAge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoresData" /> class.
        /// </summary>
        /// <param name="activity">
        /// Activity score for the given day.<br/>
        /// Example: 92
        /// </param>
        /// <param name="recovery">
        /// Recovery score for the given day.<br/>
        /// Example: 78
        /// </param>
        /// <param name="sleep">
        /// Sleep score for the given day, pertaining to the previous night's sleep.<br/>
        /// Example: 85
        /// </param>
        /// <param name="biologicalAge">
        /// Biological age computed for the given day.<br/>
        /// Example: 27
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoresData(
            double? activity,
            double? recovery,
            double? sleep,
            double? biologicalAge)
        {
            this.Activity = activity;
            this.Recovery = recovery;
            this.Sleep = sleep;
            this.BiologicalAge = biologicalAge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoresData" /> class.
        /// </summary>
        public ScoresData()
        {
        }
    }
}