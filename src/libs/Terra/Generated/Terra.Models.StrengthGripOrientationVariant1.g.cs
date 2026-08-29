
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthGripOrientationVariant1
    {
        /// <summary>
        ///
        /// </summary>
        BottomsUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthGripOrientationVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthGripOrientationVariant1 value)
        {
            return value switch
            {
                StrengthGripOrientationVariant1.BottomsUp => "bottoms_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthGripOrientationVariant1? ToEnum(string value)
        {
            return value switch
            {
                "bottoms_up" => StrengthGripOrientationVariant1.BottomsUp,
                _ => null,
            };
        }
    }
}