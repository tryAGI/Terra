
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadinessData
    {
        /// <summary>
        /// User's readiness score for a given day, resulting from the sleep session.<br/>
        /// Example: 85
        /// </summary>
        /// <example>85</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("readiness")]
        public int? Readiness { get; set; }

        /// <summary>
        /// User's recovery score for a given day, resulting from the sleep session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery_level")]
        public double? RecoveryLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadinessData" /> class.
        /// </summary>
        /// <param name="readiness">
        /// User's readiness score for a given day, resulting from the sleep session.<br/>
        /// Example: 85
        /// </param>
        /// <param name="recoveryLevel">
        /// User's recovery score for a given day, resulting from the sleep session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadinessData(
            int? readiness,
            double? recoveryLevel)
        {
            this.Readiness = readiness;
            this.RecoveryLevel = recoveryLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadinessData" /> class.
        /// </summary>
        public ReadinessData()
        {
        }
    }
}