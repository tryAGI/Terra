
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestProcessing
    {
        /// <summary>
        /// Recommended time after which the request may be retried<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_after_seconds")]
        public double? RetryAfterSeconds { get; set; }

        /// <summary>
        /// Example: Request is being processed
        /// </summary>
        /// <example>Request is being processed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: processing
        /// </summary>
        /// <example>processing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Terra User object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Terra.TerraUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestProcessing" /> class.
        /// </summary>
        /// <param name="retryAfterSeconds">
        /// Recommended time after which the request may be retried<br/>
        /// Example: 30
        /// </param>
        /// <param name="message">
        /// Example: Request is being processed
        /// </param>
        /// <param name="type">
        /// Example: processing
        /// </param>
        /// <param name="user">
        /// Terra User object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestProcessing(
            double? retryAfterSeconds,
            string? message,
            string? type,
            global::Terra.TerraUser? user)
        {
            this.RetryAfterSeconds = retryAfterSeconds;
            this.Message = message;
            this.Type = type;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestProcessing" /> class.
        /// </summary>
        public RequestProcessing()
        {
        }
    }
}