
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionConditionTypeVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Power,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant6 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant6.Power => "power",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant6? ToEnum(string value)
        {
            return value switch
            {
                "power" => CompletionConditionTypeVariant6.Power,
                _ => null,
            };
        }
    }
}