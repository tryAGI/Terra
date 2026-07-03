
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabReportListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.LabReportSession> Sessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportListResponse" /> class.
        /// </summary>
        /// <param name="sessions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportListResponse(
            global::System.Collections.Generic.IList<global::Terra.LabReportSession> sessions)
        {
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportListResponse" /> class.
        /// </summary>
        public LabReportListResponse()
        {
        }

    }
}