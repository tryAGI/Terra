
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthGripOrientationVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Neutral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthGripOrientationVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthGripOrientationVariant3 value)
        {
            return value switch
            {
                StrengthGripOrientationVariant3.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthGripOrientationVariant3? ToEnum(string value)
        {
            return value switch
            {
                "neutral" => StrengthGripOrientationVariant3.Neutral,
                _ => null,
            };
        }
    }
}