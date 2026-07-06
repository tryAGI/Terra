#nullable enable

namespace Terra
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List integrations with details<br/>
        /// Returns supported integrations with details, optionally filtered to your enabled integrations and to those that require the SDK.
        /// </summary>
        /// <param name="sdk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.IntegrationsResponse> IntegrationsListDetailedAsync(
            bool? sdk = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List integrations with details<br/>
        /// Returns supported integrations with details, optionally filtered to your enabled integrations and to those that require the SDK.
        /// </summary>
        /// <param name="sdk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.IntegrationsResponse>> IntegrationsListDetailedAsResponseAsync(
            bool? sdk = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}