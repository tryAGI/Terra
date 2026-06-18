
#nullable enable

namespace Terra
{
    /// <summary>
    /// Condition that completes a step or repeats a step block
    /// </summary>
    public sealed partial class CompletionCondition
    {
        /// <summary>
        /// How a step or block is considered complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.CompletionConditionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.CompletionConditionType Type { get; set; }

        /// <summary>
        /// Single value for the condition (e.g. seconds for time, meters for distance)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Lower bound when the condition is a range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_low")]
        public double? ValueLow { get; set; }

        /// <summary>
        /// Upper bound when the condition is a range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_high")]
        public double? ValueHigh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionCondition" /> class.
        /// </summary>
        /// <param name="type">
        /// How a step or block is considered complete
        /// </param>
        /// <param name="value">
        /// Single value for the condition (e.g. seconds for time, meters for distance)
        /// </param>
        /// <param name="valueLow">
        /// Lower bound when the condition is a range
        /// </param>
        /// <param name="valueHigh">
        /// Upper bound when the condition is a range
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionCondition(
            global::Terra.CompletionConditionType type,
            double? value,
            double? valueLow,
            double? valueHigh)
        {
            this.Type = type;
            this.Value = value;
            this.ValueLow = valueLow;
            this.ValueHigh = valueHigh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionCondition" /> class.
        /// </summary>
        public CompletionCondition()
        {
        }

    }
}