
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyFetchResponse4
    {
        /// <summary>
        /// An error message<br/>
        /// Example: unauthorized
        /// </summary>
        /// <example>unauthorized</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyFetchResponse4" /> class.
        /// </summary>
        /// <param name="message">
        /// An error message<br/>
        /// Example: unauthorized
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyFetchResponse4(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyFetchResponse4" /> class.
        /// </summary>
        public DailyFetchResponse4()
        {
        }
    }
}