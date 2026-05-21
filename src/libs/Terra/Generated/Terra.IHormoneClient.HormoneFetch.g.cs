#nullable enable

namespace Terra
{
    public partial interface IHormoneClient
    {
        /// <summary>
        /// Retrieve hormone data for a given connection ID<br/>
        /// Fetches hormone test events (LH, E3G, PDG, HCG, FSH) for a given connection. Each entry is one test event; hormones not measured at that event appear as null. v3 endpoint, uses x-terra-client-id and x-terra-client-secret headers for authentication.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.HormoneFetchResponse2, global::Terra.NoDataReturned>> HormoneFetchAsync(
            string connectionId,
            global::System.DateTime startDate,
            global::System.DateTime? endDate = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve hormone data for a given connection ID<br/>
        /// Fetches hormone test events (LH, E3G, PDG, HCG, FSH) for a given connection. Each entry is one test event; hormones not measured at that event appear as null. v3 endpoint, uses x-terra-client-id and x-terra-client-secret headers for authentication.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.OneOf<global::Terra.HormoneFetchResponse2, global::Terra.NoDataReturned>>> HormoneFetchAsResponseAsync(
            string connectionId,
            global::System.DateTime startDate,
            global::System.DateTime? endDate = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}