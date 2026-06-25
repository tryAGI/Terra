#nullable enable

namespace Terra
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Resend a previously delivered webhook payload<br/>
        /// Re-dispatches a stored normalised payload to your configured webhook<br/>
        /// destinations, identified by the original webhook event ID. The user<br/>
        /// and data type are read from the stored payload itself, so only the<br/>
        /// event ID is required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.WebhooksResendPayloadResponse> WebhooksResendPayloadAsync(

            global::Terra.WebhooksResendPayloadRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resend a previously delivered webhook payload<br/>
        /// Re-dispatches a stored normalised payload to your configured webhook<br/>
        /// destinations, identified by the original webhook event ID. The user<br/>
        /// and data type are read from the stored payload itself, so only the<br/>
        /// event ID is required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.WebhooksResendPayloadResponse>> WebhooksResendPayloadAsResponseAsync(

            global::Terra.WebhooksResendPayloadRequest request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resend a previously delivered webhook payload<br/>
        /// Re-dispatches a stored normalised payload to your configured webhook<br/>
        /// destinations, identified by the original webhook event ID. The user<br/>
        /// and data type are read from the stored payload itself, so only the<br/>
        /// event ID is required.
        /// </summary>
        /// <param name="eventId">
        /// ID of the original webhook event to resend (the `reference` field surfaced on the original delivery).<br/>
        /// Example: 5b04b6a4-09bd-4fc4-8bbb-6c44f0a2c0ef
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.WebhooksResendPayloadResponse> WebhooksResendPayloadAsync(
            string eventId,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}