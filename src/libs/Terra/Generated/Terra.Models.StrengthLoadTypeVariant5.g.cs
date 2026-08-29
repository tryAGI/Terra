
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthLoadTypeVariant5
    {
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthLoadTypeVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthLoadTypeVariant5 value)
        {
            return value switch
            {
                StrengthLoadTypeVariant5.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthLoadTypeVariant5? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => StrengthLoadTypeVariant5.Unknown,
                _ => null,
            };
        }
    }
}