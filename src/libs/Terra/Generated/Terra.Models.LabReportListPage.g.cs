
#nullable enable

namespace Terra
{
    /// <summary>
    /// One page of the report list, newest first, as API version 2026-10-21 and later serve it.
    /// </summary>
    public sealed partial class LabReportListPage
    {
        /// <summary>
        /// This page's sessions, summary fields only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.LabReportSession> Data { get; set; }

        /// <summary>
        /// Whether another page follows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Opaque cursor for the next page; send it back as cursor with the same filters. null on the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportListPage" /> class.
        /// </summary>
        /// <param name="data">
        /// This page's sessions, summary fields only.
        /// </param>
        /// <param name="hasMore">
        /// Whether another page follows.
        /// </param>
        /// <param name="nextCursor">
        /// Opaque cursor for the next page; send it back as cursor with the same filters. null on the last page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportListPage(
            global::System.Collections.Generic.IList<global::Terra.LabReportSession> data,
            bool hasMore,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportListPage" /> class.
        /// </summary>
        public LabReportListPage()
        {
        }

    }
}