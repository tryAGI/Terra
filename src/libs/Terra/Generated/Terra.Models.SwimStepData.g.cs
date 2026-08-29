
#nullable enable

namespace Terra
{
    /// <summary>
    /// Swimming details for a step
    /// </summary>
    public sealed partial class SwimStepData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_type")]
        public global::Terra.SwimStrokeType? StrokeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drill_type")]
        public global::Terra.DrillType? DrillType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equipment")]
        public global::System.Collections.Generic.IList<global::Terra.SwimEquipmentType>? Equipment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SwimStepData" /> class.
        /// </summary>
        /// <param name="strokeType"></param>
        /// <param name="drillType"></param>
        /// <param name="equipment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SwimStepData(
            global::Terra.SwimStrokeType? strokeType,
            global::Terra.DrillType? drillType,
            global::System.Collections.Generic.IList<global::Terra.SwimEquipmentType>? equipment)
        {
            this.StrokeType = strokeType;
            this.DrillType = drillType;
            this.Equipment = equipment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwimStepData" /> class.
        /// </summary>
        public SwimStepData()
        {
        }

    }
}