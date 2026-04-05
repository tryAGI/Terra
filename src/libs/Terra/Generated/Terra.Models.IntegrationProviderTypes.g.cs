
#nullable enable

namespace Terra
{
    /// <summary>
    /// Indicates the types of data available through the provider
    /// </summary>
    public sealed partial class IntegrationProviderTypes
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public bool? Activity { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public bool? Body { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nutrition")]
        public bool? Nutrition { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily")]
        public bool? Daily { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep")]
        public bool? Sleep { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("menstruation")]
        public bool? Menstruation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationProviderTypes" /> class.
        /// </summary>
        /// <param name="activity">
        /// Example: true
        /// </param>
        /// <param name="body">
        /// Example: false
        /// </param>
        /// <param name="nutrition">
        /// Example: false
        /// </param>
        /// <param name="daily">
        /// Example: false
        /// </param>
        /// <param name="sleep">
        /// Example: false
        /// </param>
        /// <param name="menstruation">
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationProviderTypes(
            bool? activity,
            bool? body,
            bool? nutrition,
            bool? daily,
            bool? sleep,
            bool? menstruation)
        {
            this.Activity = activity;
            this.Body = body;
            this.Nutrition = nutrition;
            this.Daily = daily;
            this.Sleep = sleep;
            this.Menstruation = menstruation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationProviderTypes" /> class.
        /// </summary>
        public IntegrationProviderTypes()
        {
        }
    }
}