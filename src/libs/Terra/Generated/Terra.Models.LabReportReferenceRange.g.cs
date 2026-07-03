
#nullable enable

namespace Terra
{
    /// <summary>
    /// One reference range. `type` describes the range, not a verdict on the result.
    /// </summary>
    public sealed partial class LabReportReferenceRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lower")]
        public double? Lower { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upper")]
        public double? Upper { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The patient dimensions a reference range is scoped by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Terra.LabReportRangeContext? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportReferenceRange" /> class.
        /// </summary>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <param name="type"></param>
        /// <param name="context">
        /// The patient dimensions a reference range is scoped by.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportReferenceRange(
            double? lower,
            double? upper,
            string? type,
            global::Terra.LabReportRangeContext? context)
        {
            this.Lower = lower;
            this.Upper = upper;
            this.Type = type;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportReferenceRange" /> class.
        /// </summary>
        public LabReportReferenceRange()
        {
        }

    }
}