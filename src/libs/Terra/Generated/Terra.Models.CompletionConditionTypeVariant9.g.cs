
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant9
    {
        /// <summary>
        ///
        /// </summary>
        PowerPercentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant9 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant9.PowerPercentage => "power_percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant9? ToEnum(string value)
        {
            return value switch
            {
                "power_percentage" => CompletionConditionTypeVariant9.PowerPercentage,
                _ => null,
            };
        }
    }
}