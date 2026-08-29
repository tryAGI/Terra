
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionConditionTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Distance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant2 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant2.Distance => "distance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "distance" => CompletionConditionTypeVariant2.Distance,
                _ => null,
            };
        }
    }
}