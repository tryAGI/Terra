
#nullable enable

namespace Terra
{
    /// <summary>
    /// The patient dimensions a reference range is scoped by.
    /// </summary>
    public sealed partial class LabReportRangeContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sex")]
        public string? Sex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_lower")]
        public int? AgeLower { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_upper")]
        public int? AgeUpper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pregnancy_status")]
        public string? PregnancyStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gestational_week_lower")]
        public int? GestationalWeekLower { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gestational_week_upper")]
        public int? GestationalWeekUpper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cycle_phase")]
        public string? CyclePhase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_population")]
        public string? ReferencePopulation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifiers")]
        public global::System.Collections.Generic.IList<string>? Modifiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportRangeContext" /> class.
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="ageLower"></param>
        /// <param name="ageUpper"></param>
        /// <param name="pregnancyStatus"></param>
        /// <param name="gestationalWeekLower"></param>
        /// <param name="gestationalWeekUpper"></param>
        /// <param name="cyclePhase"></param>
        /// <param name="referencePopulation"></param>
        /// <param name="modifiers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportRangeContext(
            string? sex,
            int? ageLower,
            int? ageUpper,
            string? pregnancyStatus,
            int? gestationalWeekLower,
            int? gestationalWeekUpper,
            string? cyclePhase,
            string? referencePopulation,
            global::System.Collections.Generic.IList<string>? modifiers)
        {
            this.Sex = sex;
            this.AgeLower = ageLower;
            this.AgeUpper = ageUpper;
            this.PregnancyStatus = pregnancyStatus;
            this.GestationalWeekLower = gestationalWeekLower;
            this.GestationalWeekUpper = gestationalWeekUpper;
            this.CyclePhase = cyclePhase;
            this.ReferencePopulation = referencePopulation;
            this.Modifiers = modifiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportRangeContext" /> class.
        /// </summary>
        public LabReportRangeContext()
        {
        }

    }
}