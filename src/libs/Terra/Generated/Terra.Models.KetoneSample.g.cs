
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KetoneSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Ketone in mg per dL<br/>
        /// Example: 1.5
        /// </summary>
        /// <example>1.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ketone_mg_per_dL")]
        public double? KetoneMgPerDL { get; set; }

        /// <summary>
        /// Flag indicating the ketone sample type (e.g. blood, breath, urine)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_type")]
        public double? SampleType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KetoneSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="ketoneMgPerDL">
        /// Ketone in mg per dL<br/>
        /// Example: 1.5
        /// </param>
        /// <param name="sampleType">
        /// Flag indicating the ketone sample type (e.g. blood, breath, urine)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KetoneSample(
            string? timestamp,
            double? ketoneMgPerDL,
            double? sampleType)
        {
            this.Timestamp = timestamp;
            this.KetoneMgPerDL = ketoneMgPerDL;
            this.SampleType = sampleType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KetoneSample" /> class.
        /// </summary>
        public KetoneSample()
        {
        }
    }
}