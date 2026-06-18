
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionConditionTypeVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Reps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionConditionTypeVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionConditionTypeVariant7 value)
        {
            return value switch
            {
                CompletionConditionTypeVariant7.Reps => "reps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionConditionTypeVariant7? ToEnum(string value)
        {
            return value switch
            {
                "reps" => CompletionConditionTypeVariant7.Reps,
                _ => null,
            };
        }
    }
}