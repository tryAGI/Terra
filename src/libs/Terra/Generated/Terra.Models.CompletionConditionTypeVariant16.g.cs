
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant16
    {
        /// <summary>
        ///
        /// </summary>
        PowerPercentageLessThan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant16 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant16.PowerPercentageLessThan => "power_percentage_less_than",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant16? ToEnum(string value)
        {
            return value switch
            {
                "power_percentage_less_than" => CompletionConditionTypeVariant16.PowerPercentageLessThan,
                _ => null,
            };
        }
    }
}