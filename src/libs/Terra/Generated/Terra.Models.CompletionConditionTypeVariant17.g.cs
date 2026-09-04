
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant17
    {
        /// <summary>
        ///
        /// </summary>
        PowerPercentageGreaterThan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant17Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant17 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant17.PowerPercentageGreaterThan => "power_percentage_greater_than",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant17? ToEnum(string value)
        {
            return value switch
            {
                "power_percentage_greater_than" => CompletionConditionTypeVariant17.PowerPercentageGreaterThan,
                _ => null,
            };
        }
    }
}