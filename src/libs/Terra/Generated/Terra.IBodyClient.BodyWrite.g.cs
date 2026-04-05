#nullable enable

namespace Terra
{
    public partial interface IBodyClient
    {
        /// <summary>
        /// Post body data to a provider<br/>
        /// Used to post body data to a provider. This endpoint only works for users connected via Google Fit. Returns error for other providers.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.BodyWriteResponse> BodyWriteAsync(

            global::Terra.BodyWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post body data to a provider<br/>
        /// Used to post body data to a provider. This endpoint only works for users connected via Google Fit. Returns error for other providers.
        /// </summary>
        /// <param name="data">
        /// Body measurement metrics to post to data provider
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.BodyWriteResponse> BodyWriteAsync(
            global::System.Collections.Generic.IList<global::Terra.Body> data,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}