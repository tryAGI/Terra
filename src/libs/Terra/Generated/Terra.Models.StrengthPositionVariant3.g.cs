
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthPositionVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Elevated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant3 value)
        {
            return value switch
            {
                StrengthPositionVariant3.Elevated => "elevated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant3? ToEnum(string value)
        {
            return value switch
            {
                "elevated" => StrengthPositionVariant3.Elevated,
                _ => null,
            };
        }
    }
}