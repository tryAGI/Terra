
#nullable enable

namespace Terra
{
    /// <summary>
    /// Authentication success event
    /// </summary>
    public sealed partial class AuthSuccessEvent
    {
        /// <summary>
        /// Status of authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AuthSuccessEventStatusJsonConverter))]
        public global::Terra.AuthSuccessEventStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// Client-provided reference ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceId { get; set; }

        /// <summary>
        /// Widget session identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget_session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WidgetSessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSuccessEvent" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="referenceId">
        /// Client-provided reference ID
        /// </param>
        /// <param name="widgetSessionId">
        /// Widget session identifier
        /// </param>
        /// <param name="status">
        /// Status of authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthSuccessEvent(
            global::Terra.TerraUser user,
            string referenceId,
            string widgetSessionId,
            global::Terra.AuthSuccessEventStatus status)
        {
            this.Status = status;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.ReferenceId = referenceId ?? throw new global::System.ArgumentNullException(nameof(referenceId));
            this.WidgetSessionId = widgetSessionId ?? throw new global::System.ArgumentNullException(nameof(widgetSessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSuccessEvent" /> class.
        /// </summary>
        public AuthSuccessEvent()
        {
        }
    }
}