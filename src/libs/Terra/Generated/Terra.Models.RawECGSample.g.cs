
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RawECGSample
    {
        /// <summary>
        /// Potential uV in the RawECG Sample<br/>
        /// Example: 1250.5
        /// </summary>
        /// <example>1250.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("potential_uV")]
        public double? PotentialUV { get; set; }

        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RawECGSample" /> class.
        /// </summary>
        /// <param name="potentialUV">
        /// Potential uV in the RawECG Sample<br/>
        /// Example: 1250.5
        /// </param>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RawECGSample(
            double? potentialUV,
            string? timestamp)
        {
            this.PotentialUV = potentialUV;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawECGSample" /> class.
        /// </summary>
        public RawECGSample()
        {
        }
    }
}