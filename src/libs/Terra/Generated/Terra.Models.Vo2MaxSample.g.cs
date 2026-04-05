
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Vo2MaxSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// User's VO2Max - maximum amount of oxygen the user's body can utilize during exercise<br/>
        /// Example: 45.5
        /// </summary>
        /// <example>45.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vo2max_ml_per_min_per_kg")]
        public double? Vo2maxMlPerMinPerKg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Vo2MaxSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="vo2maxMlPerMinPerKg">
        /// User's VO2Max - maximum amount of oxygen the user's body can utilize during exercise<br/>
        /// Example: 45.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Vo2MaxSample(
            string? timestamp,
            double? vo2maxMlPerMinPerKg)
        {
            this.Timestamp = timestamp;
            this.Vo2maxMlPerMinPerKg = vo2maxMlPerMinPerKg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vo2MaxSample" /> class.
        /// </summary>
        public Vo2MaxSample()
        {
        }
    }
}