
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Meal
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("micros")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.NutritionMicros Micros { get; set; }

        /// <summary>
        /// Enum representing the category the consumed food/meal falls under (i.e. Breakfast/Lunch/Dinner etc)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Type { get; set; }

        /// <summary>
        /// Identifier for food logged by the user.<br/>
        /// Example: food_123
        /// </summary>
        /// <example>food_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp the food is associated with, in ISO8601 format, with microsecond precision.<br/>
        /// Example: 2022-12-12T08:53:00.000000+02:00
        /// </summary>
        /// <example>2022-12-12T08:53:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.NutritionQuantity Quantity { get; set; }

        /// <summary>
        /// Name of food logged by the user.<br/>
        /// Example: Oatmeal
        /// </summary>
        /// <example>Oatmeal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("macros")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.NutritionMacros Macros { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Meal" /> class.
        /// </summary>
        /// <param name="micros"></param>
        /// <param name="type">
        /// Enum representing the category the consumed food/meal falls under (i.e. Breakfast/Lunch/Dinner etc)
        /// </param>
        /// <param name="id">
        /// Identifier for food logged by the user.<br/>
        /// Example: food_123
        /// </param>
        /// <param name="timestamp">
        /// Timestamp the food is associated with, in ISO8601 format, with microsecond precision.<br/>
        /// Example: 2022-12-12T08:53:00.000000+02:00
        /// </param>
        /// <param name="quantity"></param>
        /// <param name="name">
        /// Name of food logged by the user.<br/>
        /// Example: Oatmeal
        /// </param>
        /// <param name="macros"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Meal(
            global::Terra.NutritionMicros micros,
            double type,
            string id,
            string timestamp,
            global::Terra.NutritionQuantity quantity,
            string name,
            global::Terra.NutritionMacros macros)
        {
            this.Micros = micros ?? throw new global::System.ArgumentNullException(nameof(micros));
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Quantity = quantity ?? throw new global::System.ArgumentNullException(nameof(quantity));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Macros = macros ?? throw new global::System.ArgumentNullException(nameof(macros));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Meal" /> class.
        /// </summary>
        public Meal()
        {
        }
    }
}