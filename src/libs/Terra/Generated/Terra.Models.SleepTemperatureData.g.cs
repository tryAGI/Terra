
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SleepTemperatureData
    {
        /// <summary>
        /// Variation in user's skin temperature from their baseline.<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public double? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepTemperatureData" /> class.
        /// </summary>
        /// <param name="delta">
        /// Variation in user's skin temperature from their baseline.<br/>
        /// Example: 0.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepTemperatureData(
            double? delta)
        {
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepTemperatureData" /> class.
        /// </summary>
        public SleepTemperatureData()
        {
        }
    }
}