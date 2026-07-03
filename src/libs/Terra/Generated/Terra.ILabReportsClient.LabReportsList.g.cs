#nullable enable

namespace Terra
{
    public partial interface ILabReportsClient
    {
        /// <summary>
        /// List lab report sessions<br/>
        /// List lab report sessions for your account, with optional reference, upload, and inclusive date-range filters. Use the date filters to narrow large result sets.
        /// </summary>
        /// <param name="referenceId"></param>
        /// <param name="uploadId"></param>
        /// <param name="reportDateFrom"></param>
        /// <param name="reportDateTo"></param>
        /// <param name="uploadedAtFrom"></param>
        /// <param name="uploadedAtTo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportListResponse> LabReportsListAsync(
            string? referenceId = default,
            string? uploadId = default,
            global::System.DateTime? reportDateFrom = default,
            global::System.DateTime? reportDateTo = default,
            global::System.DateTime? uploadedAtFrom = default,
            global::System.DateTime? uploadedAtTo = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List lab report sessions<br/>
        /// List lab report sessions for your account, with optional reference, upload, and inclusive date-range filters. Use the date filters to narrow large result sets.
        /// </summary>
        /// <param name="referenceId"></param>
        /// <param name="uploadId"></param>
        /// <param name="reportDateFrom"></param>
        /// <param name="reportDateTo"></param>
        /// <param name="uploadedAtFrom"></param>
        /// <param name="uploadedAtTo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.LabReportListResponse>> LabReportsListAsResponseAsync(
            string? referenceId = default,
            string? uploadId = default,
            global::System.DateTime? reportDateFrom = default,
            global::System.DateTime? reportDateTo = default,
            global::System.DateTime? uploadedAtFrom = default,
            global::System.DateTime? uploadedAtTo = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}