
#nullable enable

namespace Terra
{
    /// <summary>
    /// The completed lab report resource. Shares the layered result/panel shapes with the retrieve endpoint, minus the session-lifecycle fields (status, byte counts, timestamps).
    /// </summary>
    public sealed partial class LabReportEventData
    {
        /// <summary>
        /// Example: 297405620317847552
        /// </summary>
        /// <example>297405620317847552</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Your external reference; omitted if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// Date printed on the report (YYYY-MM-DD); omitted if not extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_date")]
        public string? ReportDate { get; set; }

        /// <summary>
        /// Time printed on the report (HH:MM, 24-hour); omitted if not extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_time")]
        public string? ReportTime { get; set; }

        /// <summary>
        /// Example: en-GB
        /// </summary>
        /// <example>en-GB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_locale")]
        public string? ReportLocale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ResultsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.LabReportEventResult> Results { get; set; }

        /// <summary>
        /// Report-level panels that results reference by panel_id. Omitted if the report has no panel grouping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panels")]
        public global::System.Collections.Generic.IList<global::Terra.LabReportPanel>? Panels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_notes")]
        public string? ReportNotes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventData" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Example: 297405620317847552
        /// </param>
        /// <param name="resultsCount"></param>
        /// <param name="results"></param>
        /// <param name="referenceId">
        /// Your external reference; omitted if not set.
        /// </param>
        /// <param name="reportDate">
        /// Date printed on the report (YYYY-MM-DD); omitted if not extracted.
        /// </param>
        /// <param name="reportTime">
        /// Time printed on the report (HH:MM, 24-hour); omitted if not extracted.
        /// </param>
        /// <param name="reportLocale">
        /// Example: en-GB
        /// </param>
        /// <param name="panels">
        /// Report-level panels that results reference by panel_id. Omitted if the report has no panel grouping.
        /// </param>
        /// <param name="reportNotes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportEventData(
            string sessionId,
            long resultsCount,
            global::System.Collections.Generic.IList<global::Terra.LabReportEventResult> results,
            string? referenceId,
            string? reportDate,
            string? reportTime,
            string? reportLocale,
            global::System.Collections.Generic.IList<global::Terra.LabReportPanel>? panels,
            string? reportNotes)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.ReferenceId = referenceId;
            this.ReportDate = reportDate;
            this.ReportTime = reportTime;
            this.ReportLocale = reportLocale;
            this.ResultsCount = resultsCount;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Panels = panels;
            this.ReportNotes = reportNotes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventData" /> class.
        /// </summary>
        public LabReportEventData()
        {
        }

    }
}