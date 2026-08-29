
#nullable enable

namespace Terra
{
    /// <summary>
    /// The single typed value of a result. Exactly one value field is set, named by type.
    /// </summary>
    public sealed partial class LabReportMeasurement
    {
        /// <summary>
        /// One of numeric, bounded, qualitative, text, absent.<br/>
        /// Example: numeric
        /// </summary>
        /// <example>numeric</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeric")]
        public double? Numeric { get; set; }

        /// <summary>
        /// A one-sided bound. operator is lt or gt; value is the magnitude (e.g. lt with 0.5 means &lt;0.5).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounded")]
        public global::Terra.LabReportBoundedValue? Bounded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qualitative")]
        public global::Terra.LabReportQualitativeValue? Qualitative { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("absent_reason")]
        public string? AbsentReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        public string? Units { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ucum_code")]
        public string? UcumCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportMeasurement" /> class.
        /// </summary>
        /// <param name="type">
        /// One of numeric, bounded, qualitative, text, absent.<br/>
        /// Example: numeric
        /// </param>
        /// <param name="numeric"></param>
        /// <param name="bounded">
        /// A one-sided bound. operator is lt or gt; value is the magnitude (e.g. lt with 0.5 means &lt;0.5).
        /// </param>
        /// <param name="qualitative"></param>
        /// <param name="text"></param>
        /// <param name="absentReason"></param>
        /// <param name="units"></param>
        /// <param name="ucumCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportMeasurement(
            string type,
            double? numeric,
            global::Terra.LabReportBoundedValue? bounded,
            global::Terra.LabReportQualitativeValue? qualitative,
            string? text,
            string? absentReason,
            string? units,
            string? ucumCode)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Numeric = numeric;
            this.Bounded = bounded;
            this.Qualitative = qualitative;
            this.Text = text;
            this.AbsentReason = absentReason;
            this.Units = units;
            this.UcumCode = ucumCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportMeasurement" /> class.
        /// </summary>
        public LabReportMeasurement()
        {
        }

    }
}