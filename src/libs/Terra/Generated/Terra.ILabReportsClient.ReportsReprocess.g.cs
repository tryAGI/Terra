#nullable enable

namespace Terra
{
    public partial interface ILabReportsClient
    {
        /// <summary>
        /// Reprocess a session<br/>
        /// Re-run extraction and standardization on an existing session from its stored input files. The session re-enters the processing flow, its stored results are replaced, and a new delivery to the environment's current destinations occurs on completion. Only a session that was delivered (`sent`, `partially_sent`, `delivery_failed`) or has failed can be reprocessed. Re-running a failed report helps when its `error.retriable` is true; otherwise the input must change first. A report is metered once: reprocessing a session that was already metered does not meter it again. Each session can be reprocessed at most 3 times; a further request is refused with 409 and problem code `reprocess_limit_reached`.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="sessionId"></param>
        /// <param name="legacyFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportReprocessResponse> ReportsReprocessAsync(
            string sessionId,
            global::System.DateTime? xTerraVersion = default,
            bool? legacyFormat = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reprocess a session<br/>
        /// Re-run extraction and standardization on an existing session from its stored input files. The session re-enters the processing flow, its stored results are replaced, and a new delivery to the environment's current destinations occurs on completion. Only a session that was delivered (`sent`, `partially_sent`, `delivery_failed`) or has failed can be reprocessed. Re-running a failed report helps when its `error.retriable` is true; otherwise the input must change first. A report is metered once: reprocessing a session that was already metered does not meter it again. Each session can be reprocessed at most 3 times; a further request is refused with 409 and problem code `reprocess_limit_reached`.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="sessionId"></param>
        /// <param name="legacyFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.LabReportReprocessResponse>> ReportsReprocessAsResponseAsync(
            string sessionId,
            global::System.DateTime? xTerraVersion = default,
            bool? legacyFormat = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}