
#nullable enable

namespace Terra
{
    /// <summary>
    /// The verbatim provenance layer — what the report literally printed.
    /// </summary>
    public sealed partial class LabReportResultSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel")]
        public string? Panel { get; set; }

        /// <summary>
        /// Raw value string as printed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        public string? Units { get; set; }

        /// <summary>
        /// Verbatim flag; the coded form is under `interpretation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        public string? Flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_text")]
        public string? ReferenceText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportResultSource" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="panel"></param>
        /// <param name="value">
        /// Raw value string as printed.
        /// </param>
        /// <param name="units"></param>
        /// <param name="flag">
        /// Verbatim flag; the coded form is under `interpretation`.
        /// </param>
        /// <param name="method"></param>
        /// <param name="notes"></param>
        /// <param name="referenceText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportResultSource(
            string? name,
            string? panel,
            string? value,
            string? units,
            string? flag,
            string? method,
            string? notes,
            string? referenceText)
        {
            this.Name = name;
            this.Panel = panel;
            this.Value = value;
            this.Units = units;
            this.Flag = flag;
            this.Method = method;
            this.Notes = notes;
            this.ReferenceText = referenceText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportResultSource" /> class.
        /// </summary>
        public LabReportResultSource()
        {
        }

    }
}