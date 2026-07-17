
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservationCode
    {
        /// <summary>
        /// The vocabulary the code belongs to: the source platform's identifier system (e.g. healthkit) or a standard terminology URI (e.g. http://snomed.info/sct, http://loinc.org).<br/>
        /// Example: healthkit
        /// </summary>
        /// <example>healthkit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string System { get; set; }

        /// <summary>
        /// The code identifying the observation within the system.<br/>
        /// Example: HKCategoryTypeIdentifierIntermenstrualBleeding
        /// </summary>
        /// <example>HKCategoryTypeIdentifierIntermenstrualBleeding</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable display name for the code, where the system provides one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display")]
        public string? Display { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationCode" /> class.
        /// </summary>
        /// <param name="system">
        /// The vocabulary the code belongs to: the source platform's identifier system (e.g. healthkit) or a standard terminology URI (e.g. http://snomed.info/sct, http://loinc.org).<br/>
        /// Example: healthkit
        /// </param>
        /// <param name="code">
        /// The code identifying the observation within the system.<br/>
        /// Example: HKCategoryTypeIdentifierIntermenstrualBleeding
        /// </param>
        /// <param name="display">
        /// Human-readable display name for the code, where the system provides one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservationCode(
            string system,
            string code,
            string? display)
        {
            this.System = system ?? throw new global::System.ArgumentNullException(nameof(system));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Display = display;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationCode" /> class.
        /// </summary>
        public ObservationCode()
        {
        }

    }
}