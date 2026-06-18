
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionConditionTypeVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        HrPercentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant8 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant8.HrPercentage => "hr_percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant8? ToEnum(string value)
        {
            return value switch
            {
                "hr_percentage" => CompletionConditionTypeVariant8.HrPercentage,
                _ => null,
            };
        }
    }
}