
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HealthObservationData
    {
        /// <summary>
        /// Coarse grouping of the observation, usable for filtering and permissioning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public double? Category { get; set; }

        /// <summary>
        /// Normalized snake_case observation identifier.<br/>
        /// Example: intermenstrual_bleeding
        /// </summary>
        /// <example>intermenstrual_bleeding</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("observation_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObservationType { get; set; }

        /// <summary>
        /// (system, code) tuples identifying the observation in the source platform's vocabulary and, where mapped, standard terminologies (SNOMED CT, LOINC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codes")]
        public global::System.Collections.Generic.IList<global::Terra.ObservationCode>? Codes { get; set; }

        /// <summary>
        /// The observation's value. Absent or NONE-typed for presence-only events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Terra.ObservationValue? Value { get; set; }

        /// <summary>
        /// Severity, for symptom observations. Mirrors HealthKit severity semantics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        public double? Severity { get; set; }

        /// <summary>
        /// Coded sub-values of a multi-part observation (e.g. State of Mind valence and labels).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        public global::System.Collections.Generic.IList<global::Terra.ObservationComponent>? Components { get; set; }

        /// <summary>
        /// Record lifecycle. ENTERED_IN_ERROR retracts the record with this summary_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        /// Free-text note attached to the observation by the user or source platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthObservationData" /> class.
        /// </summary>
        /// <param name="observationType">
        /// Normalized snake_case observation identifier.<br/>
        /// Example: intermenstrual_bleeding
        /// </param>
        /// <param name="category">
        /// Coarse grouping of the observation, usable for filtering and permissioning.
        /// </param>
        /// <param name="codes">
        /// (system, code) tuples identifying the observation in the source platform's vocabulary and, where mapped, standard terminologies (SNOMED CT, LOINC).
        /// </param>
        /// <param name="value">
        /// The observation's value. Absent or NONE-typed for presence-only events.
        /// </param>
        /// <param name="severity">
        /// Severity, for symptom observations. Mirrors HealthKit severity semantics.
        /// </param>
        /// <param name="components">
        /// Coded sub-values of a multi-part observation (e.g. State of Mind valence and labels).
        /// </param>
        /// <param name="status">
        /// Record lifecycle. ENTERED_IN_ERROR retracts the record with this summary_id.
        /// </param>
        /// <param name="notes">
        /// Free-text note attached to the observation by the user or source platform.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HealthObservationData(
            string observationType,
            double? category,
            global::System.Collections.Generic.IList<global::Terra.ObservationCode>? codes,
            global::Terra.ObservationValue? value,
            double? severity,
            global::System.Collections.Generic.IList<global::Terra.ObservationComponent>? components,
            double? status,
            string? notes)
        {
            this.Category = category;
            this.ObservationType = observationType ?? throw new global::System.ArgumentNullException(nameof(observationType));
            this.Codes = codes;
            this.Value = value;
            this.Severity = severity;
            this.Components = components;
            this.Status = status;
            this.Notes = notes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthObservationData" /> class.
        /// </summary>
        public HealthObservationData()
        {
        }

    }
}