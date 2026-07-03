
#nullable enable

namespace Terra
{
    /// <summary>
    /// A one-sided bound. operator is `lt` or `gt`; value is the magnitude (e.g. lt with 0.5 means "&lt;0.5").
    /// </summary>
    public sealed partial class LabReportBoundedValue
    {
        /// <summary>
        /// `lt` or `gt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportBoundedValue" /> class.
        /// </summary>
        /// <param name="operator">
        /// `lt` or `gt`.
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportBoundedValue(
            string @operator,
            double value)
        {
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportBoundedValue" /> class.
        /// </summary>
        public LabReportBoundedValue()
        {
        }

    }
}