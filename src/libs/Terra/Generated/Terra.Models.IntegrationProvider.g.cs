
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationProvider
    {
        /// <summary>
        /// Identifier for the provider<br/>
        /// Example: MAPMYFITNESS
        /// </summary>
        /// <example>MAPMYFITNESS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Display name of the integration<br/>
        /// Example: MapMyFitness
        /// </summary>
        /// <example>MapMyFitness</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL for the provider's icon image<br/>
        /// Example: https://api.tryterra.co/v2/static/assets/img/app_icons/mapmyfitness.webp
        /// </summary>
        /// <example>https://api.tryterra.co/v2/static/assets/img/app_icons/mapmyfitness.webp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Indicates how the integration is set up<br/>
        /// Example: API_KEYS_MANAGED
        /// </summary>
        /// <example>API_KEYS_MANAGED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        public string? Setup { get; set; }

        /// <summary>
        /// Whether the integration is enabled<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates the types of data available through the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("types")]
        public global::Terra.IntegrationProviderTypes? Types { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationProvider" /> class.
        /// </summary>
        /// <param name="provider">
        /// Identifier for the provider<br/>
        /// Example: MAPMYFITNESS
        /// </param>
        /// <param name="name">
        /// Display name of the integration<br/>
        /// Example: MapMyFitness
        /// </param>
        /// <param name="icon">
        /// URL for the provider's icon image<br/>
        /// Example: https://api.tryterra.co/v2/static/assets/img/app_icons/mapmyfitness.webp
        /// </param>
        /// <param name="setup">
        /// Indicates how the integration is set up<br/>
        /// Example: API_KEYS_MANAGED
        /// </param>
        /// <param name="enabled">
        /// Whether the integration is enabled<br/>
        /// Example: true
        /// </param>
        /// <param name="types">
        /// Indicates the types of data available through the provider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationProvider(
            string? provider,
            string? name,
            string? icon,
            string? setup,
            bool? enabled,
            global::Terra.IntegrationProviderTypes? types)
        {
            this.Provider = provider;
            this.Name = name;
            this.Icon = icon;
            this.Setup = setup;
            this.Enabled = enabled;
            this.Types = types;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationProvider" /> class.
        /// </summary>
        public IntegrationProvider()
        {
        }
    }
}