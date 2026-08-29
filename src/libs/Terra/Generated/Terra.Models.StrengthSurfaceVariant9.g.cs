
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthSurfaceVariant9
    {
        /// <summary>
        ///
        /// </summary>
        Treadmill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSurfaceVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSurfaceVariant9 value)
        {
            return value switch
            {
                StrengthSurfaceVariant9.Treadmill => "treadmill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSurfaceVariant9? ToEnum(string value)
        {
            return value switch
            {
                "treadmill" => StrengthSurfaceVariant9.Treadmill,
                _ => null,
            };
        }
    }
}