#nullable enable

namespace Terra
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Get list of available integrations<br/>
        /// Retrieve a list of all available provider integrations on the API.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.IntegrationsFetchResponse> IntegrationsFetchAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}