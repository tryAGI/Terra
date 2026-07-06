#nullable enable

namespace Terra
{
    public partial interface ILabReportsClient
    {
        /// <summary>
        /// Retrieve a lab report session<br/>
        /// Retrieve a report's metadata, results, reference ranges, and status history. Immutable and cacheable — presigned file URLs and mutable per-destination delivery state live on the `/files` and `/deliveries` sub-resources.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportSession> LabReportsGetAsync(
            string sessionId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a lab report session<br/>
        /// Retrieve a report's metadata, results, reference ranges, and status history. Immutable and cacheable — presigned file URLs and mutable per-destination delivery state live on the `/files` and `/deliveries` sub-resources.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.LabReportSession>> LabReportsGetAsResponseAsync(
            string sessionId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}