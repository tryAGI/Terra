
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsFetchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.IList<string>? Providers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk_resource")]
        public global::System.Collections.Generic.IList<string>? SdkResource { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.IntegrationsFetchResponseStatusJsonConverter))]
        public global::Terra.IntegrationsFetchResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsFetchResponse" /> class.
        /// </summary>
        /// <param name="providers"></param>
        /// <param name="sdkResource"></param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsFetchResponse(
            global::System.Collections.Generic.IList<string>? providers,
            global::System.Collections.Generic.IList<string>? sdkResource,
            global::Terra.IntegrationsFetchResponseStatus? status)
        {
            this.Providers = providers;
            this.SdkResource = sdkResource;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsFetchResponse" /> class.
        /// </summary>
        public IntegrationsFetchResponse()
        {
        }
    }
}