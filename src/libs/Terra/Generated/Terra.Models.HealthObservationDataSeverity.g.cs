
#nullable enable

namespace Terra
{
    /// <summary>
    /// Severity, for symptom observations. Mirrors HealthKit severity semantics.
    /// </summary>
    public sealed partial class HealthObservationDataSeverity
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}