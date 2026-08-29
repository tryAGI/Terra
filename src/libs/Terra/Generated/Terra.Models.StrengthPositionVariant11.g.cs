
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthPositionVariant11
    {
        /// <summary>
        ///
        /// </summary>
        Lying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant11 value)
        {
            return value switch
            {
                StrengthPositionVariant11.Lying => "lying",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant11? ToEnum(string value)
        {
            return value switch
            {
                "lying" => StrengthPositionVariant11.Lying,
                _ => null,
            };
        }
    }
}