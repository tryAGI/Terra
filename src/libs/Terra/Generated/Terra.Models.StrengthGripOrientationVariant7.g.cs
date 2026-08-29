
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthGripOrientationVariant7
    {
        /// <summary>
        ///
        /// </summary>
        Underhand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthGripOrientationVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthGripOrientationVariant7 value)
        {
            return value switch
            {
                StrengthGripOrientationVariant7.Underhand => "underhand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthGripOrientationVariant7? ToEnum(string value)
        {
            return value switch
            {
                "underhand" => StrengthGripOrientationVariant7.Underhand,
                _ => null,
            };
        }
    }
}