
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthPositionVariant1
    {
        /// <summary>
        ///
        /// </summary>
        BentOver,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant1 value)
        {
            return value switch
            {
                StrengthPositionVariant1.BentOver => "bent_over",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant1? ToEnum(string value)
        {
            return value switch
            {
                "bent_over" => StrengthPositionVariant1.BentOver,
                _ => null,
            };
        }
    }
}