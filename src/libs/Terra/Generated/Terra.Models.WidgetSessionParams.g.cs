
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetSessionParams
    {
        /// <summary>
        /// Comma separated list of providers to display on the device selection page. This overrides your selected sources on your dashboard<br/>
        /// Example: GARMIN,FITBIT,OURA,WITHINGS,SUUNTO
        /// </summary>
        /// <example>GARMIN,FITBIT,OURA,WITHINGS,SUUNTO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public string? Providers { get; set; }

        /// <summary>
        /// Display language of the widget<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Identifier of the end user on your system, such as a user ID or email associated with them<br/>
        /// Example: user123@email.com
        /// </summary>
        /// <example>user123@email.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// URL the user is redirected to upon successful authentication<br/>
        /// Example: https://myapp.com/success
        /// </summary>
        /// <example>https://myapp.com/success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_success_redirect_url")]
        public string? AuthSuccessRedirectUrl { get; set; }

        /// <summary>
        /// URL the user is redirected to upon unsuccessful authentication<br/>
        /// Example: https://myapp.com/failure
        /// </summary>
        /// <example>https://myapp.com/failure</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_failure_redirect_url")]
        public string? AuthFailureRedirectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetSessionParams" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetSessionParams(
            string? providers,
            string? language,
            string? referenceId,
            string? authSuccessRedirectUrl,
            string? authFailureRedirectUrl)
        {
            this.Providers = providers;
            this.Language = language;
            this.ReferenceId = referenceId;
            this.AuthSuccessRedirectUrl = authSuccessRedirectUrl;
            this.AuthFailureRedirectUrl = authFailureRedirectUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetSessionParams" /> class.
        /// </summary>
        public WidgetSessionParams()
        {
        }
    }
}