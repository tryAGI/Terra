
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionConditionTypeVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant5 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant5.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant5? ToEnum(string value)
        {
            return value switch
            {
                "open" => CompletionConditionTypeVariant5.Open,
                _ => null,
            };
        }
    }
}