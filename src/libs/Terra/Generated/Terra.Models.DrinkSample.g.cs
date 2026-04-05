
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DrinkSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Volume of drink consumed<br/>
        /// Example: 250
        /// </summary>
        /// <example>250</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drink_volume")]
        public double? DrinkVolume { get; set; }

        /// <summary>
        /// Unit of measurement for the drink<br/>
        /// Example: ml
        /// </summary>
        /// <example>ml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drink_unit")]
        public string? DrinkUnit { get; set; }

        /// <summary>
        /// Name of drink consumed.<br/>
        /// Example: Water
        /// </summary>
        /// <example>Water</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("drink_name")]
        public string? DrinkName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DrinkSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="drinkVolume">
        /// Volume of drink consumed<br/>
        /// Example: 250
        /// </param>
        /// <param name="drinkUnit">
        /// Unit of measurement for the drink<br/>
        /// Example: ml
        /// </param>
        /// <param name="drinkName">
        /// Name of drink consumed.<br/>
        /// Example: Water
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DrinkSample(
            string? timestamp,
            double? drinkVolume,
            string? drinkUnit,
            string? drinkName)
        {
            this.Timestamp = timestamp;
            this.DrinkVolume = drinkVolume;
            this.DrinkUnit = drinkUnit;
            this.DrinkName = drinkName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrinkSample" /> class.
        /// </summary>
        public DrinkSample()
        {
        }
    }
}