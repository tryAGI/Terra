#nullable enable

namespace Terra
{
    public partial interface ILabReportsClient
    {
        /// <summary>
        /// List report sessions<br/>
        /// List report sessions for your account — both lab reports and scans — with optional reference, upload, and inclusive date-range filters. Use the date filters to narrow large result sets, and read `report_type` on each session to tell a lab panel from a scan.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="referenceId"></param>
        /// <param name="reportType"></param>
        /// <param name="uploadId"></param>
        /// <param name="reportDateFrom"></param>
        /// <param name="reportDateTo"></param>
        /// <param name="uploadedAtFrom"></param>
        /// <param name="uploadedAtTo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.LabReportListPage, global::Terra.LabReportListResponse>> ReportsListAsync(
            global::System.DateTime? xTerraVersion = default,
            int? limit = default,
            string? cursor = default,
            string? referenceId = default,
            global::Terra.ReportsListReportType? reportType = default,
            string? uploadId = default,
            global::System.DateTime? reportDateFrom = default,
            global::System.DateTime? reportDateTo = default,
            global::System.DateTime? uploadedAtFrom = default,
            global::System.DateTime? uploadedAtTo = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List report sessions<br/>
        /// List report sessions for your account — both lab reports and scans — with optional reference, upload, and inclusive date-range filters. Use the date filters to narrow large result sets, and read `report_type` on each session to tell a lab panel from a scan.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="referenceId"></param>
        /// <param name="reportType"></param>
        /// <param name="uploadId"></param>
        /// <param name="reportDateFrom"></param>
        /// <param name="reportDateTo"></param>
        /// <param name="uploadedAtFrom"></param>
        /// <param name="uploadedAtTo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.OneOf<global::Terra.LabReportListPage, global::Terra.LabReportListResponse>>> ReportsListAsResponseAsync(
            global::System.DateTime? xTerraVersion = default,
            int? limit = default,
            string? cursor = default,
            string? referenceId = default,
            global::Terra.ReportsListReportType? reportType = default,
            string? uploadId = default,
            global::System.DateTime? reportDateFrom = default,
            global::System.DateTime? reportDateTo = default,
            global::System.DateTime? uploadedAtFrom = default,
            global::System.DateTime? uploadedAtTo = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}