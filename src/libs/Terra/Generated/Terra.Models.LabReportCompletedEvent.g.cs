
#nullable enable

namespace Terra
{
    /// <summary>
    /// Lab report completed event: a report finished processing; its normalized results are delivered under `data`.
    /// </summary>
    public sealed partial class LabReportCompletedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.LabReportCompletedEventTypeJsonConverter))]
        public global::Terra.LabReportCompletedEventType Type { get; set; }

        /// <summary>
        /// Stable event id; identical across redeliveries of the same event — dedup on it.<br/>
        /// Example: evt_4a2b8c1d-3f9e-4c0a-8b21-9d6e5f2a1c7b
        /// </summary>
        /// <example>evt_4a2b8c1d-3f9e-4c0a-8b21-9d6e5f2a1c7b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// RFC3339 UTC instant the event occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("occurred_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime OccurredAt { get; set; }

        /// <summary>
        /// Correlates every event produced from one upload (a multi-report upload fans out to several); omitted for sessions minted before the upload contract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string? UploadId { get; set; }

        /// <summary>
        /// The completed lab report resource. Shares the layered result/panel shapes with the retrieve endpoint, minus the session-lifecycle fields (status, byte counts, timestamps).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.LabReportEventData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportCompletedEvent" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Stable event id; identical across redeliveries of the same event — dedup on it.<br/>
        /// Example: evt_4a2b8c1d-3f9e-4c0a-8b21-9d6e5f2a1c7b
        /// </param>
        /// <param name="occurredAt">
        /// RFC3339 UTC instant the event occurred.
        /// </param>
        /// <param name="data">
        /// The completed lab report resource. Shares the layered result/panel shapes with the retrieve endpoint, minus the session-lifecycle fields (status, byte counts, timestamps).
        /// </param>
        /// <param name="type"></param>
        /// <param name="uploadId">
        /// Correlates every event produced from one upload (a multi-report upload fans out to several); omitted for sessions minted before the upload contract.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportCompletedEvent(
            string eventId,
            global::System.DateTime occurredAt,
            global::Terra.LabReportEventData data,
            global::Terra.LabReportCompletedEventType type,
            string? uploadId)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.OccurredAt = occurredAt;
            this.UploadId = uploadId;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportCompletedEvent" /> class.
        /// </summary>
        public LabReportCompletedEvent()
        {
        }

    }
}