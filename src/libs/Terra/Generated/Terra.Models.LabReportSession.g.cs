
#nullable enable

namespace Terra
{
    /// <summary>
    /// A lab report session. Returned in full on retrieve; list items carry the summary fields only (no results/panels).
    /// </summary>
    public sealed partial class LabReportSession
    {
        /// <summary>
        /// Example: 297405620317847552
        /// </summary>
        /// <example>297405620317847552</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string? UploadId { get; set; }

        /// <summary>
        /// Your external reference; omitted if not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// Report type as a clean lowercase string (open enum — handle unknown values gracefully).<br/>
        /// Example: lab
        /// </summary>
        /// <example>lab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReportType { get; set; }

        /// <summary>
        /// Current status as a clean lowercase string (open enum), e.g. processing, sent, partially_sent, failed.<br/>
        /// Example: sent
        /// </summary>
        /// <example>sent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_at")]
        public global::System.DateTime? UploadedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

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
        /// Specimen collection date (YYYY-MM-DD); omitted if not extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_date")]
        public string? CollectionDate { get; set; }

        /// <summary>
        /// Specimen collection time (HH:MM, 24-hour); omitted if not extracted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_time")]
        public string? CollectionTime { get; set; }

        /// <summary>
        /// Example: en-GB
        /// </summary>
        /// <example>en-GB</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_locale")]
        public string? ReportLocale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lab_name")]
        public string? LabName { get; set; }

        /// <summary>
        /// Patient age in years; omitted if unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patient_age_at_collection")]
        public int? PatientAgeAtCollection { get; set; }

        /// <summary>
        /// Clean lowercase string (open enum); omitted if unspecified.<br/>
        /// Example: female
        /// </summary>
        /// <example>female</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("patient_sex")]
        public string? PatientSex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_bytes")]
        public long? InputBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results_count")]
        public int? ResultsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_bytes")]
        public long? OutputBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_count")]
        public int? FileCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_history")]
        public global::System.Collections.Generic.IList<global::Terra.LabReportStatusEntry>? StatusHistory { get; set; }

        /// <summary>
        /// The layered biomarker results. Populated on retrieve, not on list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Terra.LabReportResult>? Results { get; set; }

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
        /// Initializes a new instance of the <see cref="LabReportSession" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Example: 297405620317847552
        /// </param>
        /// <param name="reportType">
        /// Report type as a clean lowercase string (open enum — handle unknown values gracefully).<br/>
        /// Example: lab
        /// </param>
        /// <param name="currentStatus">
        /// Current status as a clean lowercase string (open enum), e.g. processing, sent, partially_sent, failed.<br/>
        /// Example: sent
        /// </param>
        /// <param name="uploadId"></param>
        /// <param name="referenceId">
        /// Your external reference; omitted if not set.
        /// </param>
        /// <param name="uploadedAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="reportDate">
        /// Date printed on the report (YYYY-MM-DD); omitted if not extracted.
        /// </param>
        /// <param name="reportTime">
        /// Time printed on the report (HH:MM, 24-hour); omitted if not extracted.
        /// </param>
        /// <param name="collectionDate">
        /// Specimen collection date (YYYY-MM-DD); omitted if not extracted.
        /// </param>
        /// <param name="collectionTime">
        /// Specimen collection time (HH:MM, 24-hour); omitted if not extracted.
        /// </param>
        /// <param name="reportLocale">
        /// Example: en-GB
        /// </param>
        /// <param name="labName"></param>
        /// <param name="patientAgeAtCollection">
        /// Patient age in years; omitted if unknown.
        /// </param>
        /// <param name="patientSex">
        /// Clean lowercase string (open enum); omitted if unspecified.<br/>
        /// Example: female
        /// </param>
        /// <param name="inputBytes"></param>
        /// <param name="resultsCount"></param>
        /// <param name="outputBytes"></param>
        /// <param name="fileCount"></param>
        /// <param name="statusHistory"></param>
        /// <param name="results">
        /// The layered biomarker results. Populated on retrieve, not on list.
        /// </param>
        /// <param name="panels">
        /// Report-level panels that results reference by panel_id. Omitted if the report has no panel grouping.
        /// </param>
        /// <param name="reportNotes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportSession(
            string sessionId,
            string reportType,
            string currentStatus,
            string? uploadId,
            string? referenceId,
            global::System.DateTime? uploadedAt,
            global::System.DateTime? updatedAt,
            string? reportDate,
            string? reportTime,
            string? collectionDate,
            string? collectionTime,
            string? reportLocale,
            string? labName,
            int? patientAgeAtCollection,
            string? patientSex,
            long? inputBytes,
            int? resultsCount,
            long? outputBytes,
            int? fileCount,
            global::System.Collections.Generic.IList<global::Terra.LabReportStatusEntry>? statusHistory,
            global::System.Collections.Generic.IList<global::Terra.LabReportResult>? results,
            global::System.Collections.Generic.IList<global::Terra.LabReportPanel>? panels,
            string? reportNotes)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.UploadId = uploadId;
            this.ReferenceId = referenceId;
            this.ReportType = reportType ?? throw new global::System.ArgumentNullException(nameof(reportType));
            this.CurrentStatus = currentStatus ?? throw new global::System.ArgumentNullException(nameof(currentStatus));
            this.UploadedAt = uploadedAt;
            this.UpdatedAt = updatedAt;
            this.ReportDate = reportDate;
            this.ReportTime = reportTime;
            this.CollectionDate = collectionDate;
            this.CollectionTime = collectionTime;
            this.ReportLocale = reportLocale;
            this.LabName = labName;
            this.PatientAgeAtCollection = patientAgeAtCollection;
            this.PatientSex = patientSex;
            this.InputBytes = inputBytes;
            this.ResultsCount = resultsCount;
            this.OutputBytes = outputBytes;
            this.FileCount = fileCount;
            this.StatusHistory = statusHistory;
            this.Results = results;
            this.Panels = panels;
            this.ReportNotes = reportNotes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportSession" /> class.
        /// </summary>
        public LabReportSession()
        {
        }

    }
}