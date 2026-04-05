
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SwimmingData
    {
        /// <summary>
        /// Total number of swimming laps performed during the day.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_laps")]
        public int? NumLaps { get; set; }

        /// <summary>
        /// Total number of swimming strokes performed during the day.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_strokes")]
        public int? NumStrokes { get; set; }

        /// <summary>
        /// Pool length for associated with the day.<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_length_meters")]
        public int? PoolLengthMeters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SwimmingData" /> class.
        /// </summary>
        /// <param name="numLaps">
        /// Total number of swimming laps performed during the day.<br/>
        /// Example: 20
        /// </param>
        /// <param name="numStrokes">
        /// Total number of swimming strokes performed during the day.<br/>
        /// Example: 500
        /// </param>
        /// <param name="poolLengthMeters">
        /// Pool length for associated with the day.<br/>
        /// Example: 25
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SwimmingData(
            int? numLaps,
            int? numStrokes,
            int? poolLengthMeters)
        {
            this.NumLaps = numLaps;
            this.NumStrokes = numStrokes;
            this.PoolLengthMeters = poolLengthMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwimmingData" /> class.
        /// </summary>
        public SwimmingData()
        {
        }
    }
}