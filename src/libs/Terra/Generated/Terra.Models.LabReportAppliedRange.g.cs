
#nullable enable

namespace Terra
{
    /// <summary>
    /// Bounds of the reference range the flag was judged against.
    /// </summary>
    public sealed partial class LabReportAppliedRange
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportAppliedRange" /> class.
        /// </summary>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportAppliedRange(
            double? lower,
            double? upper)
        {
            this.Lower = lower;
            this.Upper = upper;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportAppliedRange" /> class.
        /// </summary>
        public LabReportAppliedRange()
        {
        }

    }
}