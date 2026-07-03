
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabReportQualitativeValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Coded qualitative answer (LOINC/SNOMED) when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportQualitativeValue" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="code">
        /// Coded qualitative answer (LOINC/SNOMED) when available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportQualitativeValue(
            string? text,
            string? code)
        {
            this.Text = text;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportQualitativeValue" /> class.
        /// </summary>
        public LabReportQualitativeValue()
        {
        }

    }
}