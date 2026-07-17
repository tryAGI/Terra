
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservationValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ValueType { get; set; }

        /// <summary>
        /// Numeric value, set when value_type is QUANTITY.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Unit for the quantity, set when value_type is QUANTITY.<br/>
        /// Example: count
        /// </summary>
        /// <example>count</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Boolean finding, set when value_type is BOOLEAN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boolean")]
        public bool? Boolean { get; set; }

        /// <summary>
        /// Free-text value, set when value_type is STRING.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Coded value, set when value_type is CODE.<br/>
        /// Example: luteinizing_hormone_surge
        /// </summary>
        /// <example>luteinizing_hormone_surge</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationValue" /> class.
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="quantity">
        /// Numeric value, set when value_type is QUANTITY.<br/>
        /// Example: 2
        /// </param>
        /// <param name="unit">
        /// Unit for the quantity, set when value_type is QUANTITY.<br/>
        /// Example: count
        /// </param>
        /// <param name="boolean">
        /// Boolean finding, set when value_type is BOOLEAN.
        /// </param>
        /// <param name="text">
        /// Free-text value, set when value_type is STRING.
        /// </param>
        /// <param name="code">
        /// Coded value, set when value_type is CODE.<br/>
        /// Example: luteinizing_hormone_surge
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservationValue(
            double valueType,
            double? quantity,
            string? unit,
            bool? boolean,
            string? text,
            string? code)
        {
            this.ValueType = valueType;
            this.Quantity = quantity;
            this.Unit = unit;
            this.Boolean = boolean;
            this.Text = text;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationValue" /> class.
        /// </summary>
        public ObservationValue()
        {
        }

    }
}