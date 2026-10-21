#nullable enable

namespace Terra
{
    public partial interface ILabReportsClient
    {
        /// <summary>
        /// Upload a report<br/>
        /// Upload one report as multipart form data: one `file` part, or one per page for a report photographed page by page, sent in page order. Each file may be a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image, and is identified by its contents rather than its name or declared type. All the files of an upload are read as one report and produce one session, so upload separate reports separately. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; learn the `session_id` from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="referenceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportUploadResponse> ReportsUploadAsync(

            global::Terra.ReportsUploadRequest request,
            global::System.DateTime? xTerraVersion = default,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a report<br/>
        /// Upload one report as multipart form data: one `file` part, or one per page for a report photographed page by page, sent in page order. Each file may be a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image, and is identified by its contents rather than its name or declared type. All the files of an upload are read as one report and produce one session, so upload separate reports separately. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; learn the `session_id` from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="referenceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.LabReportUploadResponse>> ReportsUploadAsResponseAsync(

            global::Terra.ReportsUploadRequest request,
            global::System.DateTime? xTerraVersion = default,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a report<br/>
        /// Upload one report as multipart form data: one `file` part, or one per page for a report photographed page by page, sent in page order. Each file may be a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image, and is identified by its contents rather than its name or declared type. All the files of an upload are read as one report and produce one session, so upload separate reports separately. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; learn the `session_id` from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="referenceId"></param>
        /// <param name="file">
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
        /// </param>
        /// <param name="filename">
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportUploadResponse> ReportsUploadAsync(
            byte[] file,
            string filename,
            global::System.DateTime? xTerraVersion = default,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a report<br/>
        /// Upload one report as multipart form data: one `file` part, or one per page for a report photographed page by page, sent in page order. Each file may be a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image, and is identified by its contents rather than its name or declared type. All the files of an upload are read as one report and produce one session, so upload separate reports separately. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; learn the `session_id` from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="referenceId"></param>
        /// <param name="file">
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
        /// </param>
        /// <param name="filename">
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportUploadResponse> ReportsUploadAsync(
            global::System.IO.Stream file,
            string filename,
            global::System.DateTime? xTerraVersion = default,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a report<br/>
        /// Upload one report as multipart form data: one `file` part, or one per page for a report photographed page by page, sent in page order. Each file may be a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image, and is identified by its contents rather than its name or declared type. All the files of an upload are read as one report and produce one session, so upload separate reports separately. Both clinical lab reports and DXA body-composition/bone-density scans go to this endpoint — Terra identifies which it is from the file, so there is no parameter to declare the type; read `report_type` off the session or the webhook. Returns an `upload_id`; learn the `session_id` from the webhook events or from `GET /reports?upload_id=...`.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="referenceId"></param>
        /// <param name="file">
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
        /// </param>
        /// <param name="filename">
        /// A file of the report: a PDF or a PNG, JPEG, GIF, WebP or HEIC/HEIF image. Repeat the `file` part, up to 20 times, to send a report's pages as separate files, in the order of the pages. At most 20 MB per file and 50 MB per upload, of which at most 22.5 MB PDF. Files are stored as uploaded, so a HEIC photo keeps its EXIF metadata, location included; strip it before uploading if that matters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.LabReportUploadResponse>> ReportsUploadAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::System.DateTime? xTerraVersion = default,
            string? referenceId = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}