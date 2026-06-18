
#nullable enable

namespace Terra
{
    /// <summary>
    /// An error response, following RFC 9457 (Problem Details for HTTP APIs, which obsoletes RFC 7807). Returned with `Content-Type: application/problem+json` on every 4xx/5xx response. The HTTP status line carries the status code; it is intentionally not repeated in the body. `type`, `title` and `instance` are always present; `detail` is included when a specific explanation is available.
    /// </summary>
    public sealed partial class Problem
    {
        /// <summary>
        /// A URI reference identifying the problem type. Defaults to `about:blank`.<br/>
        /// Example: about:blank
        /// </summary>
        /// <example>about:blank</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// A short, human-readable summary of the problem type (the lowercased HTTP status text).<br/>
        /// Example: unauthorized
        /// </summary>
        /// <example>unauthorized</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The request path, including any query string, that produced this problem.<br/>
        /// Example: /api/v2/activity?user_id=d4aba475-f714-4663-88fe-28f18b8599b0&amp;to_webhook=false
        /// </summary>
        /// <example>/api/v2/activity?user_id=d4aba475-f714-4663-88fe-28f18b8599b0&amp;to_webhook=false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instance { get; set; }

        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.<br/>
        /// Example: dev-id or x-api-key headers are missing
        /// </summary>
        /// <example>dev-id or x-api-key headers are missing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem" /> class.
        /// </summary>
        /// <param name="type">
        /// A URI reference identifying the problem type. Defaults to `about:blank`.<br/>
        /// Example: about:blank
        /// </param>
        /// <param name="title">
        /// A short, human-readable summary of the problem type (the lowercased HTTP status text).<br/>
        /// Example: unauthorized
        /// </param>
        /// <param name="instance">
        /// The request path, including any query string, that produced this problem.<br/>
        /// Example: /api/v2/activity?user_id=d4aba475-f714-4663-88fe-28f18b8599b0&amp;to_webhook=false
        /// </param>
        /// <param name="detail">
        /// A human-readable explanation specific to this occurrence of the problem.<br/>
        /// Example: dev-id or x-api-key headers are missing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Problem(
            string type,
            string title,
            string instance,
            string? detail)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Instance = instance ?? throw new global::System.ArgumentNullException(nameof(instance));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem" /> class.
        /// </summary>
        public Problem()
        {
        }

    }
}