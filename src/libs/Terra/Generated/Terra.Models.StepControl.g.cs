
#nullable enable

namespace Terra
{
    /// <summary>
    /// Equipment control applied during a step
    /// </summary>
    public sealed partial class StepControl
    {
        /// <summary>
        /// Equipment control adjusted during a step (e.g. treadmill incline)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.StepControlTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.StepControlType Type { get; set; }

        /// <summary>
        /// Control value (e.g. 0.02 for a 2% treadmill grade)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepControl" /> class.
        /// </summary>
        /// <param name="type">
        /// Equipment control adjusted during a step (e.g. treadmill incline)
        /// </param>
        /// <param name="value">
        /// Control value (e.g. 0.02 for a 2% treadmill grade)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepControl(
            global::Terra.StepControlType type,
            double value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepControl" /> class.
        /// </summary>
        public StepControl()
        {
        }

    }
}