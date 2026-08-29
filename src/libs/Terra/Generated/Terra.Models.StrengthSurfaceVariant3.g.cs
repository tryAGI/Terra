
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthSurfaceVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Box,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSurfaceVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSurfaceVariant3 value)
        {
            return value switch
            {
                StrengthSurfaceVariant3.Box => "box",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSurfaceVariant3? ToEnum(string value)
        {
            return value switch
            {
                "box" => StrengthSurfaceVariant3.Box,
                _ => null,
            };
        }
    }
}