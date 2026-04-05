#nullable enable

namespace Terra
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// Generate an authentication link, using the Terra Authentication Widget<br/>
        /// Generates a link to redirect an end user to for them to select an integration and log in with their fitness data provider
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AuthenticationGenerateWidgetSessionResponse> AuthenticationGenerateWidgetSessionAsync(

            global::Terra.WidgetSessionParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an authentication link, using the Terra Authentication Widget<br/>
        /// Generates a link to redirect an end user to for them to select an integration and log in with their fitness data provider
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AuthenticationGenerateWidgetSessionResponse> AuthenticationGenerateWidgetSessionAsync(
            string? providers = default,
            string? language = default,
            string? referenceId = default,
            string? authSuccessRedirectUrl = default,
            string? authFailureRedirectUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}