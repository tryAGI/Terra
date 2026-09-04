
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant13
    {
        /// <summary>
        ///
        /// </summary>
        HrPercentageGreaterThan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant13 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant13.HrPercentageGreaterThan => "hr_percentage_greater_than",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant13? ToEnum(string value)
        {
            return value switch
            {
                "hr_percentage_greater_than" => CompletionConditionTypeVariant13.HrPercentageGreaterThan,
                _ => null,
            };
        }
    }
}