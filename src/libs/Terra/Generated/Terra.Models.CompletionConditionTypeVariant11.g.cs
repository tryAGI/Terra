
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant11
    {
        /// <summary>
        ///
        /// </summary>
        HrGreaterThan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant11 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant11.HrGreaterThan => "hr_greater_than",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant11? ToEnum(string value)
        {
            return value switch
            {
                "hr_greater_than" => CompletionConditionTypeVariant11.HrGreaterThan,
                _ => null,
            };
        }
    }
}