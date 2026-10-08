
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WidgetSessionParams
    {
        /// <summary>
        /// Comma separated list of providers to display on the device selection page. The legacy wildcard ALL means every provider enabled on your dashboard, the same as omitting the field.<br/>
        /// Example: VALD,CATAPULT
        /// </summary>
        /// <example>VALD,CATAPULT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public string? Providers { get; set; }

        /// <summary>
        /// Identifier of the end user on your system, such as a user ID or email associated with them<br/>
        /// Example: user123@email.com
        /// </summary>
        /// <example>user123@email.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// URL the user is redirected to upon successful authentication. The legacy value multi-auth is honoured and sets multi_auth instead of acting as a URL.<br/>
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
        /// Allow Apple Health connections through the Terra mobile app<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_terra_avengers_app")]
        public bool? UseTerraAvengersApp { get; set; }

        /// <summary>
        /// Terra user IDs already connected for this end user; their providers show as connected with a disconnect option
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_uids")]
        public global::System.Collections.Generic.IList<string>? ConnectedUids { get; set; }

        /// <summary>
        /// Show disconnect buttons for providers already connected under reference_id<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_disconnect")]
        public bool? ShowDisconnect { get; set; }

        /// <summary>
        /// Keep the user on the widget after each successful connection so they can connect several providers in one session<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_auth")]
        public bool? MultiAuth { get; set; }

        /// <summary>
        /// When false, the user stays on the widget's own result screen instead of being redirected immediately<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass_feedback")]
        public bool? BypassFeedback { get; set; }

        /// <summary>
        /// URL of your own iOS app to hand Apple Health connections to, instead of the Terra mobile app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apple_app_url")]
        public string? AppleAppUrl { get; set; }

        /// <summary>
        /// URL of your own Android app to hand Samsung Health connections to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samsung_app_url")]
        public string? SamsungAppUrl { get; set; }

        /// <summary>
        /// forces the widget UI language (e.g. en, fr, ja, zh_cn); unsupported codes fall back to the end user's browser language<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetSessionParams" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetSessionParams(
            string? providers,
            string? referenceId,
            string? authSuccessRedirectUrl,
            string? authFailureRedirectUrl,
            bool? useTerraAvengersApp,
            global::System.Collections.Generic.IList<string>? connectedUids,
            bool? showDisconnect,
            bool? multiAuth,
            bool? bypassFeedback,
            string? appleAppUrl,
            string? samsungAppUrl,
            string? language)
        {
            this.Providers = providers;
            this.ReferenceId = referenceId;
            this.AuthSuccessRedirectUrl = authSuccessRedirectUrl;
            this.AuthFailureRedirectUrl = authFailureRedirectUrl;
            this.UseTerraAvengersApp = useTerraAvengersApp;
            this.ConnectedUids = connectedUids;
            this.ShowDisconnect = showDisconnect;
            this.MultiAuth = multiAuth;
            this.BypassFeedback = bypassFeedback;
            this.AppleAppUrl = appleAppUrl;
            this.SamsungAppUrl = samsungAppUrl;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetSessionParams" /> class.
        /// </summary>
        public WidgetSessionParams()
        {
        }

    }
}