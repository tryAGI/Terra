
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ECGReading
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public string? StartTimestamp { get; set; }

        /// <summary>
        /// User's average heart rate throughout the day, in beats per minute (bpm).<br/>
        /// Example: 72.5
        /// </summary>
        /// <example>72.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_hr_bpm")]
        public double? AvgHrBpm { get; set; }

        /// <summary>
        /// Flag indicating the atrial fibrillation classification of the individual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afib_classification")]
        public double? AfibClassification { get; set; }

        /// <summary>
        /// List of raw ECG readings sampled through the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_signal")]
        public global::System.Collections.Generic.IList<global::Terra.RawECGSample>? RawSignal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ECGReading" /> class.
        /// </summary>
        /// <param name="startTimestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.
        /// </param>
        /// <param name="avgHrBpm">
        /// User's average heart rate throughout the day, in beats per minute (bpm).<br/>
        /// Example: 72.5
        /// </param>
        /// <param name="afibClassification">
        /// Flag indicating the atrial fibrillation classification of the individual
        /// </param>
        /// <param name="rawSignal">
        /// List of raw ECG readings sampled through the day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ECGReading(
            string? startTimestamp,
            double? avgHrBpm,
            double? afibClassification,
            global::System.Collections.Generic.IList<global::Terra.RawECGSample>? rawSignal)
        {
            this.StartTimestamp = startTimestamp;
            this.AvgHrBpm = avgHrBpm;
            this.AfibClassification = afibClassification;
            this.RawSignal = rawSignal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ECGReading" /> class.
        /// </summary>
        public ECGReading()
        {
        }
    }
}