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
        /// Comma separated list of providers to display on the device selection page. The legacy wildcard ALL means every provider enabled on your dashboard, the same as omitting the field.<br/>
        /// Example: VALD,CATAPULT
        /// </param>
        /// <param name="referenceId">
        /// Identifier of the end user on your system, such as a user ID or email associated with them<br/>
        /// Example: user123@email.com
        /// </param>
        /// <param name="authSuccessRedirectUrl">
        /// URL the user is redirected to upon successful authentication. The legacy value multi-auth is honoured and sets multi_auth instead of acting as a URL.<br/>
        /// Example: https://myapp.com/success
        /// </param>
        /// <param name="authFailureRedirectUrl">
        /// URL the user is redirected to upon unsuccessful authentication<br/>
        /// Example: https://myapp.com/failure
        /// </param>
        /// <param name="useTerraAvengersApp">
        /// Allow Apple Health connections through the Terra mobile app<br/>
        /// Example: false
        /// </param>
        /// <param name="connectedUids">
        /// Terra user IDs already connected for this end user; their providers show as connected with a disconnect option
        /// </param>
        /// <param name="showDisconnect">
        /// Show disconnect buttons for providers already connected under reference_id<br/>
        /// Example: false
        /// </param>
        /// <param name="multiAuth">
        /// Keep the user on the widget after each successful connection so they can connect several providers in one session<br/>
        /// Example: false
        /// </param>
        /// <param name="bypassFeedback">
        /// When false, the user stays on the widget's own result screen instead of being redirected immediately<br/>
        /// Example: true
        /// </param>
        /// <param name="appleAppUrl">
        /// URL of your own iOS app to hand Apple Health connections to, instead of the Terra mobile app
        /// </param>
        /// <param name="samsungAppUrl">
        /// URL of your own Android app to hand Samsung Health connections to
        /// </param>
        /// <param name="language">
        /// forces the widget UI language (e.g. en, fr, ja, zh_cn); unsupported codes fall back to the end user's browser language<br/>
        /// Example: en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AuthenticationGenerateWidgetSessionResponse> AuthenticationGenerateWidgetSessionAsync(
            string? providers = default,
            string? referenceId = default,
            string? authSuccessRedirectUrl = default,
            string? authFailureRedirectUrl = default,
            bool? useTerraAvengersApp = default,
            global::System.Collections.Generic.IList<string>? connectedUids = default,
            bool? showDisconnect = default,
            bool? multiAuth = default,
            bool? bypassFeedback = default,
            string? appleAppUrl = default,
            string? samsungAppUrl = default,
            string? language = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}