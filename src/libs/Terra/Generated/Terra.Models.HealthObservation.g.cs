
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HealthObservation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.HealthObservationMetadata Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observation_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.HealthObservationData ObservationData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthObservation" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="observationData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HealthObservation(
            global::Terra.HealthObservationMetadata metadata,
            global::Terra.HealthObservationData observationData)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ObservationData = observationData ?? throw new global::System.ArgumentNullException(nameof(observationData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthObservation" /> class.
        /// </summary>
        public HealthObservation()
        {
        }

    }
}