
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MenstruationIntervalSample
    {
        /// <summary>
        /// Start of the cycle-phase interval, in ISO8601 format.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public string? StartTimestamp { get; set; }

        /// <summary>
        /// End of the cycle-phase interval, in ISO8601 format.<br/>
        /// Example: 2022-11-28T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-28T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        public string? EndTimestamp { get; set; }

        /// <summary>
        /// Cycle phase covered by this interval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public double? Phase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MenstruationIntervalSample" /> class.
        /// </summary>
        /// <param name="startTimestamp">
        /// Start of the cycle-phase interval, in ISO8601 format.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="endTimestamp">
        /// End of the cycle-phase interval, in ISO8601 format.<br/>
        /// Example: 2022-11-28T09:00:00.000000+02:00
        /// </param>
        /// <param name="phase">
        /// Cycle phase covered by this interval.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MenstruationIntervalSample(
            string? startTimestamp,
            string? endTimestamp,
            double? phase)
        {
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.Phase = phase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenstruationIntervalSample" /> class.
        /// </summary>
        public MenstruationIntervalSample()
        {
        }

    }
}