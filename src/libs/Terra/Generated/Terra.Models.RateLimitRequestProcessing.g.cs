
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitRequestProcessing
    {
        /// <summary>
        /// Example: Rate limit exceeded
        /// </summary>
        /// <example>Rate limit exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: rate_limit
        /// </summary>
        /// <example>rate_limit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitRequestProcessing" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message">
        /// Example: Rate limit exceeded
        /// </param>
        /// <param name="type">
        /// Example: rate_limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitRequestProcessing(
            global::Terra.TerraUser user,
            string? message,
            string? type)
        {
            this.Message = message;
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitRequestProcessing" /> class.
        /// </summary>
        public RateLimitRequestProcessing()
        {
        }
    }
}