#nullable enable

namespace Terra
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Generate a Terra Widget session link<br/>
        /// Returns a Terra Widget session with a hosted URL where the end user selects a provider and logs in.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AuthenticationGenerateWidgetSessionResponse> AuthenticationGenerateWidgetSessionAsync(

            global::Terra.WidgetSessionParams request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a Terra Widget session link<br/>
        /// Returns a Terra Widget session with a hosted URL where the end user selects a provider and logs in.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.AuthenticationGenerateWidgetSessionResponse>> AuthenticationGenerateWidgetSessionAsResponseAsync(

            global::Terra.WidgetSessionParams request,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a Terra Widget session link<br/>
        /// Returns a Terra Widget session with a hosted URL where the end user selects a provider and logs in.
        /// </summary>
        /// <param name="providers">
        /// Comma separated list of providers to display on the device selection page. This overrides your selected sources on your dashboard<br/>
        /// Example: GARMIN,FITBIT,OURA,WITHINGS,SUUNTO
        /// </param>
        /// <param name="language">
        /// Display language of the widget<br/>
        /// Example: en
        /// </param>
        /// <param name="referenceId">
        /// Identifier of the end user on your system, such as a user ID or email associated with them<br/>
        /// Example: user123@email.com
        /// </param>
        /// <param name="authSuccessRedirectUrl">
        /// URL the user is redirected to upon successful authentication<br/>
        /// Example: https://myapp.com/success
        /// </param>
        /// <param name="authFailureRedirectUrl">
        /// URL the user is redirected to upon unsuccessful authentication<br/>
        /// Example: https://myapp.com/failure
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AuthenticationGenerateWidgetSessionResponse> AuthenticationGenerateWidgetSessionAsync(
            string? providers = default,
            string? language = default,
            string? referenceId = default,
            string? authSuccessRedirectUrl = default,
            string? authFailureRedirectUrl = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}