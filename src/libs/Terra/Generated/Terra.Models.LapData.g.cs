
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LapData
    {
        /// <summary>
        /// Array of datapoints for each lap performed by the user during the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("laps")]
        public global::System.Collections.Generic.IList<global::Terra.LapSample>? Laps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LapData" /> class.
        /// </summary>
        /// <param name="laps">
        /// Array of datapoints for each lap performed by the user during the workout.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LapData(
            global::System.Collections.Generic.IList<global::Terra.LapSample>? laps)
        {
            this.Laps = laps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LapData" /> class.
        /// </summary>
        public LapData()
        {
        }
    }
}