
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant12
    {
        /// <summary>
        ///
        /// </summary>
        HrPercentageLessThan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant12 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant12.HrPercentageLessThan => "hr_percentage_less_than",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant12? ToEnum(string value)
        {
            return value switch
            {
                "hr_percentage_less_than" => CompletionConditionTypeVariant12.HrPercentageLessThan,
                _ => null,
            };
        }
    }
}