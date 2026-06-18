
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionConditionTypeVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        HrLessThan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant10 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant10.HrLessThan => "hr_less_than",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant10? ToEnum(string value)
        {
            return value switch
            {
                "hr_less_than" => CompletionConditionTypeVariant10.HrLessThan,
                _ => null,
            };
        }
    }
}