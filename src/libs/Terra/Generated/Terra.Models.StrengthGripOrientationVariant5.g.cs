
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthGripOrientationVariant5
    {
        /// <summary>
        ///
        /// </summary>
        Pinch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthGripOrientationVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthGripOrientationVariant5 value)
        {
            return value switch
            {
                StrengthGripOrientationVariant5.Pinch => "pinch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthGripOrientationVariant5? ToEnum(string value)
        {
            return value switch
            {
                "pinch" => StrengthGripOrientationVariant5.Pinch,
                _ => null,
            };
        }
    }
}