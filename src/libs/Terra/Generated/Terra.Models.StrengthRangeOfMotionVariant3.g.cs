
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthRangeOfMotionVariant3
    {
        /// <summary>
        ///
        /// </summary>
        FromHang,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthRangeOfMotionVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthRangeOfMotionVariant3 value)
        {
            return value switch
            {
                StrengthRangeOfMotionVariant3.FromHang => "from_hang",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthRangeOfMotionVariant3? ToEnum(string value)
        {
            return value switch
            {
                "from_hang" => StrengthRangeOfMotionVariant3.FromHang,
                _ => null,
            };
        }
    }
}