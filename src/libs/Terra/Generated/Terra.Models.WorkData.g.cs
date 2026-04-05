
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkData
    {
        /// <summary>
        /// Total work output of the user for the workout, in kilojoules.<br/>
        /// Example: 450.5
        /// </summary>
        /// <example>450.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("work_kilojoules")]
        public double? WorkKilojoules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkData" /> class.
        /// </summary>
        /// <param name="workKilojoules">
        /// Total work output of the user for the workout, in kilojoules.<br/>
        /// Example: 450.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkData(
            double? workKilojoules)
        {
            this.WorkKilojoules = workKilojoules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkData" /> class.
        /// </summary>
        public WorkData()
        {
        }
    }
}