
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant15
    {
        /// <summary>
        ///
        /// </summary>
        PowerGreaterThan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant15Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant15 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant15.PowerGreaterThan => "power_greater_than",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant15? ToEnum(string value)
        {
            return value switch
            {
                "power_greater_than" => CompletionConditionTypeVariant15.PowerGreaterThan,
                _ => null,
            };
        }
    }
}