
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthenticationGenerateWidgetSessionResponse
    {
        /// <summary>
        /// Session ID for the widget authentication session<br/>
        /// Example: 23dc2540-7139-44c6-8158-f81196e2cf2e
        /// </summary>
        /// <example>23dc2540-7139-44c6-8158-f81196e2cf2e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// the widget URL the user must be redirected to in order to link their account<br/>
        /// Example: https://widget.tryterra.co/session/344d475f-296a-489a-a88c-54183671dafd
        /// </summary>
        /// <example>https://widget.tryterra.co/session/344d475f-296a-489a-a88c-54183671dafd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// indicates that the request was successful (value is success)<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatusJsonConverter))]
        public global::Terra.AuthenticationGenerateWidgetSessionResponseStatus? Status { get; set; }

        /// <summary>
        /// a number in seconds depicting how long the url is valid for<br/>
        /// Example: 900
        /// </summary>
        /// <example>900</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public double? ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationGenerateWidgetSessionResponse" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Session ID for the widget authentication session<br/>
        /// Example: 23dc2540-7139-44c6-8158-f81196e2cf2e
        /// </param>
        /// <param name="url">
        /// the widget URL the user must be redirected to in order to link their account<br/>
        /// Example: https://widget.tryterra.co/session/344d475f-296a-489a-a88c-54183671dafd
        /// </param>
        /// <param name="status">
        /// indicates that the request was successful (value is success)<br/>
        /// Example: success
        /// </param>
        /// <param name="expiresIn">
        /// a number in seconds depicting how long the url is valid for<br/>
        /// Example: 900
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationGenerateWidgetSessionResponse(
            string? sessionId,
            string? url,
            global::Terra.AuthenticationGenerateWidgetSessionResponseStatus? status,
            double? expiresIn)
        {
            this.SessionId = sessionId;
            this.Url = url;
            this.Status = status;
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationGenerateWidgetSessionResponse" /> class.
        /// </summary>
        public AuthenticationGenerateWidgetSessionResponse()
        {
        }
    }
}