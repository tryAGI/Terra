
#nullable enable

namespace Terra
{
    /// <summary>
    /// One layered webhook result: the retrieve result, but its source additionally carries the specimen collection date/time.
    /// </summary>
    public sealed partial class LabReportEventResult
    {
        /// <summary>
        /// The retrieve source layer plus the specimen collection date/time (the retrieve carries these on the session, which a webhook consumer does not separately fetch).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.LabReportEventResultSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventResult" /> class.
        /// </summary>
        /// <param name="source">
        /// The retrieve source layer plus the specimen collection date/time (the retrieve carries these on the session, which a webhook consumer does not separately fetch).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportEventResult(
            global::Terra.LabReportEventResultSource source)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportEventResult" /> class.
        /// </summary>
        public LabReportEventResult()
        {
        }

    }
}