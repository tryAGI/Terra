
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Hr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant3 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant3.Hr => "hr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "hr" => CompletionConditionTypeVariant3.Hr,
                _ => null,
            };
        }
    }
}