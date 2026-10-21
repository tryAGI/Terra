#nullable enable

namespace Terra
{
    public partial interface ILabReportsClient
    {
        /// <summary>
        /// Delete a lab report session<br/>
        /// Delete a session. It is removed from the API immediately: every read of it returns 404. Its files, results and Terra's copies of them are erased from active systems within 30 days (target 24 hours), and backups expire within 10 days. Works without Lab Reports access.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task ReportsDeleteAsync(
            string sessionId,
            global::System.DateTime? xTerraVersion = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a lab report session<br/>
        /// Delete a session. It is removed from the API immediately: every read of it returns 404. Its files, results and Terra's copies of them are erased from active systems within 30 days (target 24 hours), and backups expire within 10 days. Works without Lab Reports access.
        /// </summary>
        /// <param name="xTerraVersion"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse> ReportsDeleteAsResponseAsync(
            string sessionId,
            global::System.DateTime? xTerraVersion = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}