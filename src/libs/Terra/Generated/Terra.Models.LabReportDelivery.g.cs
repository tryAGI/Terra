
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LabReportDelivery
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationId { get; set; }

        /// <summary>
        /// The destination's type (e.g. webhook, s3).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_type")]
        public string? DestinationType { get; set; }

        /// <summary>
        /// pending, delivered, or failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Retry count — 0 on the first attempt, incremented per retry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AttemptCount { get; set; }

        /// <summary>
        /// Most recent delivery error; omitted when delivered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        public string? LastError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportDelivery" /> class.
        /// </summary>
        /// <param name="destinationId"></param>
        /// <param name="status">
        /// pending, delivered, or failed.
        /// </param>
        /// <param name="attemptCount">
        /// Retry count — 0 on the first attempt, incremented per retry.
        /// </param>
        /// <param name="destinationType">
        /// The destination's type (e.g. webhook, s3).
        /// </param>
        /// <param name="lastError">
        /// Most recent delivery error; omitted when delivered.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportDelivery(
            string destinationId,
            string status,
            int attemptCount,
            string? destinationType,
            string? lastError)
        {
            this.DestinationId = destinationId ?? throw new global::System.ArgumentNullException(nameof(destinationId));
            this.DestinationType = destinationType;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.AttemptCount = attemptCount;
            this.LastError = lastError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportDelivery" /> class.
        /// </summary>
        public LabReportDelivery()
        {
        }

    }
}