#nullable enable

namespace Terra
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Get detailed list of integrations<br/>
        /// Retrieve a detailed list of supported integrations, optionally filtered by the developer's enabled integrations and the requirement for SDK usage.
        /// </summary>
        /// <param name="sdk"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.IntegrationsResponse> IntegrationsDetailedFetchAsync(
            bool? sdk = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}