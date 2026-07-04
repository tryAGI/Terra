
#nullable enable

namespace Terra
{
    /// <summary>
    /// Lab report failed event: a report terminally failed processing; `data` carries the structured reason.
    /// </summary>
    public sealed partial class LabReportFailedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.LabReportFailedEventTypeJsonConverter))]
        public global::Terra.LabReportFailedEventType Type { get; set; }

        /// <summary>
        /// Stable event id; identical across redeliveries of the same event — dedup on it.<br/>
        /// Example: evt_7c1f0a92-52c8-4a63-9082-7e50e2f5a1cd
        /// </summary>
        /// <example>evt_7c1f0a92-52c8-4a63-9082-7e50e2f5a1cd</example>
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
        /// The failed lab report resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.LabReportFailureData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFailedEvent" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Stable event id; identical across redeliveries of the same event — dedup on it.<br/>
        /// Example: evt_7c1f0a92-52c8-4a63-9082-7e50e2f5a1cd
        /// </param>
        /// <param name="occurredAt">
        /// RFC3339 UTC instant the event occurred.
        /// </param>
        /// <param name="data">
        /// The failed lab report resource.
        /// </param>
        /// <param name="type"></param>
        /// <param name="uploadId">
        /// Correlates every event produced from one upload (a multi-report upload fans out to several); omitted for sessions minted before the upload contract.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportFailedEvent(
            string eventId,
            global::System.DateTime occurredAt,
            global::Terra.LabReportFailureData data,
            global::Terra.LabReportFailedEventType type,
            string? uploadId)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.OccurredAt = occurredAt;
            this.UploadId = uploadId;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportFailedEvent" /> class.
        /// </summary>
        public LabReportFailedEvent()
        {
        }

    }
}