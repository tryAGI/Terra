#nullable enable

namespace Terra
{
    public partial interface ILabReportsClient
    {
        /// <summary>
        /// Upload a report<br/>
        /// Upload a single report file (PDF, PNG, JPEG, GIF, or WebP) as multipart form data. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; a single upload may fan out to multiple sessions, so learn the `session_id`(s) from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="referenceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportUploadResponse> ReportsUploadAsync(

            global::Terra.ReportsUploadRequest request,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a report<br/>
        /// Upload a single report file (PDF, PNG, JPEG, GIF, or WebP) as multipart form data. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; a single upload may fan out to multiple sessions, so learn the `session_id`(s) from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="referenceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.LabReportUploadResponse>> ReportsUploadAsResponseAsync(

            global::Terra.ReportsUploadRequest request,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a report<br/>
        /// Upload a single report file (PDF, PNG, JPEG, GIF, or WebP) as multipart form data. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; a single upload may fan out to multiple sessions, so learn the `session_id`(s) from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="referenceId"></param>
        /// <param name="file">
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </param>
        /// <param name="filename">
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportUploadResponse> ReportsUploadAsync(
            byte[] file,
            string filename,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a report<br/>
        /// Upload a single report file (PDF, PNG, JPEG, GIF, or WebP) as multipart form data. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; a single upload may fan out to multiple sessions, so learn the `session_id`(s) from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="referenceId"></param>
        /// <param name="file">
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </param>
        /// <param name="filename">
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportUploadResponse> ReportsUploadAsync(
            global::System.IO.Stream file,
            string filename,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a report<br/>
        /// Upload a single report file (PDF, PNG, JPEG, GIF, or WebP) as multipart form data. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; a single upload may fan out to multiple sessions, so learn the `session_id`(s) from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="referenceId"></param>
        /// <param name="file">
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </param>
        /// <param name="filename">
        /// The lab report file (PDF, PNG, JPEG, GIF, or WebP; max 20 MB).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.LabReportUploadResponse>> ReportsUploadAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}