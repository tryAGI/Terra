
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ObservationComponent
    {
        /// <summary>
        /// Identity of this sub-value, scoped to the observation_type (e.g. valence for a state-of-mind observation).<br/>
        /// Example: valence
        /// </summary>
        /// <example>valence</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The component's value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Terra.ObservationValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationComponent" /> class.
        /// </summary>
        /// <param name="code">
        /// Identity of this sub-value, scoped to the observation_type (e.g. valence for a state-of-mind observation).<br/>
        /// Example: valence
        /// </param>
        /// <param name="value">
        /// The component's value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservationComponent(
            string code,
            global::Terra.ObservationValue? value)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationComponent" /> class.
        /// </summary>
        public ObservationComponent()
        {
        }

    }
}