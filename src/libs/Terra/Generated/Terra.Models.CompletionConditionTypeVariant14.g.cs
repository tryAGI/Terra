
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant14
    {
        /// <summary>
        ///
        /// </summary>
        PowerLessThan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant14 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant14.PowerLessThan => "power_less_than",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant14? ToEnum(string value)
        {
            return value switch
            {
                "power_less_than" => CompletionConditionTypeVariant14.PowerLessThan,
                _ => null,
            };
        }
    }
}