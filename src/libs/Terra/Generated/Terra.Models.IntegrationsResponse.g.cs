
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsResponse
    {
        /// <summary>
        /// Status of the API response<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// List of integration providers with their details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.IList<global::Terra.IntegrationProvider>? Providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the API response<br/>
        /// Example: success
        /// </param>
        /// <param name="providers">
        /// List of integration providers with their details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsResponse(
            string? status,
            global::System.Collections.Generic.IList<global::Terra.IntegrationProvider>? providers)
        {
            this.Status = status;
            this.Providers = providers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsResponse" /> class.
        /// </summary>
        public IntegrationsResponse()
        {
        }
    }
}