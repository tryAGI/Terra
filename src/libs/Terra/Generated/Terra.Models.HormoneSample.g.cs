
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HormoneSample
    {
        /// <summary>
        /// ISO-8601 timestamp of the test event, including timezone offset.<br/>
        /// Example: 2026-05-07T08:00:00+02:00
        /// </summary>
        /// <example>2026-05-07T08:00:00+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Luteinizing hormone reading, milli-international units per millilitre.<br/>
        /// Example: 5.2
        /// </summary>
        /// <example>5.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lh_mIU_per_ml")]
        public double? LhMIUPerMl { get; set; }

        /// <summary>
        /// Estrone-3-glucuronide reading, nanograms per millilitre. Urinary estrogen metabolite, rises before ovulation.<br/>
        /// Example: 108.5
        /// </summary>
        /// <example>108.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("e3g_ng_per_ml")]
        public double? E3gNgPerMl { get; set; }

        /// <summary>
        /// Pregnanediol glucuronide reading, micrograms per millilitre. Urinary progesterone metabolite, confirms ovulation.<br/>
        /// Example: 2.4
        /// </summary>
        /// <example>2.4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdg_ug_per_ml")]
        public double? PdgUgPerMl { get; set; }

        /// <summary>
        /// Human chorionic gonadotropin reading, milli-international units per millilitre. Pregnancy hormone.<br/>
        /// Example: 0.8
        /// </summary>
        /// <example>0.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hcg_mIU_per_ml")]
        public double? HcgMIUPerMl { get; set; }

        /// <summary>
        /// Follicle-stimulating hormone reading, milli-international units per millilitre. Ovarian reserve / menopause indicator.<br/>
        /// Example: 4.8
        /// </summary>
        /// <example>4.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fsh_mIU_per_ml")]
        public double? FshMIUPerMl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HormoneSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// ISO-8601 timestamp of the test event, including timezone offset.<br/>
        /// Example: 2026-05-07T08:00:00+02:00
        /// </param>
        /// <param name="lhMIUPerMl">
        /// Luteinizing hormone reading, milli-international units per millilitre.<br/>
        /// Example: 5.2
        /// </param>
        /// <param name="e3gNgPerMl">
        /// Estrone-3-glucuronide reading, nanograms per millilitre. Urinary estrogen metabolite, rises before ovulation.<br/>
        /// Example: 108.5
        /// </param>
        /// <param name="pdgUgPerMl">
        /// Pregnanediol glucuronide reading, micrograms per millilitre. Urinary progesterone metabolite, confirms ovulation.<br/>
        /// Example: 2.4
        /// </param>
        /// <param name="hcgMIUPerMl">
        /// Human chorionic gonadotropin reading, milli-international units per millilitre. Pregnancy hormone.<br/>
        /// Example: 0.8
        /// </param>
        /// <param name="fshMIUPerMl">
        /// Follicle-stimulating hormone reading, milli-international units per millilitre. Ovarian reserve / menopause indicator.<br/>
        /// Example: 4.8
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HormoneSample(
            string timestamp,
            double? lhMIUPerMl,
            double? e3gNgPerMl,
            double? pdgUgPerMl,
            double? hcgMIUPerMl,
            double? fshMIUPerMl)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.LhMIUPerMl = lhMIUPerMl;
            this.E3gNgPerMl = e3gNgPerMl;
            this.PdgUgPerMl = pdgUgPerMl;
            this.HcgMIUPerMl = hcgMIUPerMl;
            this.FshMIUPerMl = fshMIUPerMl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HormoneSample" /> class.
        /// </summary>
        public HormoneSample()
        {
        }

    }
}