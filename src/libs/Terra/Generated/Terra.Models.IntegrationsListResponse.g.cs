
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IntegrationsListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.IList<string>? Providers { get; set; }

        /// <summary>
        /// Providers available through Terra's mobile SDKs rather than cloud connections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk_providers")]
        public global::System.Collections.Generic.IList<string>? SdkProviders { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.IntegrationsListResponseStatusJsonConverter))]
        public global::Terra.IntegrationsListResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsListResponse" /> class.
        /// </summary>
        /// <param name="providers"></param>
        /// <param name="sdkProviders">
        /// Providers available through Terra's mobile SDKs rather than cloud connections
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsListResponse(
            global::System.Collections.Generic.IList<string>? providers,
            global::System.Collections.Generic.IList<string>? sdkProviders,
            global::Terra.IntegrationsListResponseStatus? status)
        {
            this.Providers = providers;
            this.SdkProviders = sdkProviders;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsListResponse" /> class.
        /// </summary>
        public IntegrationsListResponse()
        {
        }

    }
}