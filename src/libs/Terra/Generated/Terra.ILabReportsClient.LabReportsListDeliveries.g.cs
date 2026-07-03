#nullable enable

namespace Terra
{
    public partial interface ILabReportsClient
    {
        /// <summary>
        /// List delivery outcomes<br/>
        /// The per-destination delivery state for a report. Each opted-in destination is tracked independently, so one failure never hides delivery to the others (and is why a session can be `partially_sent`).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.LabReportDeliveriesResponse> LabReportsListDeliveriesAsync(
            string sessionId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List delivery outcomes<br/>
        /// The per-destination delivery state for a report. Each opted-in destination is tracked independently, so one failure never hides delivery to the others (and is why a session can be `partially_sent`).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.LabReportDeliveriesResponse>> LabReportsListDeliveriesAsResponseAsync(
            string sessionId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}