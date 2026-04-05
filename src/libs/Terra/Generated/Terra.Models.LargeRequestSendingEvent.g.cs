
#nullable enable

namespace Terra
{
    /// <summary>
    /// Large request sending event
    /// </summary>
    public sealed partial class LargeRequestSendingEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.LargeRequestSendingEventTypeJsonConverter))]
        public global::Terra.LargeRequestSendingEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// Reference ID for tracking this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reference { get; set; }

        /// <summary>
        /// Information about the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Number of expected payload events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_payloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpectedPayloads { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LargeRequestSendingEvent" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="reference">
        /// Reference ID for tracking this request
        /// </param>
        /// <param name="message">
        /// Information about the request
        /// </param>
        /// <param name="expectedPayloads">
        /// Number of expected payload events
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LargeRequestSendingEvent(
            global::Terra.TerraUser user,
            string reference,
            string message,
            int expectedPayloads,
            global::Terra.LargeRequestSendingEventType type)
        {
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Reference = reference ?? throw new global::System.ArgumentNullException(nameof(reference));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ExpectedPayloads = expectedPayloads;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LargeRequestSendingEvent" /> class.
        /// </summary>
        public LargeRequestSendingEvent()
        {
        }
    }
}