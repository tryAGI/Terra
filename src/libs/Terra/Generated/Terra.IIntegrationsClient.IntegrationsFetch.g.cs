#nullable enable

namespace Terra
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Get list of available integrations<br/>
        /// Retrieve a list of all available provider integrations on the API.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.IntegrationsFetchResponse> IntegrationsFetchAsync(
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}