
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthBarPositionVariant6
    {
        /// <summary>
        ///
        /// </summary>
        Zercher,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthBarPositionVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthBarPositionVariant6 value)
        {
            return value switch
            {
                StrengthBarPositionVariant6.Zercher => "zercher",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthBarPositionVariant6? ToEnum(string value)
        {
            return value switch
            {
                "zercher" => StrengthBarPositionVariant6.Zercher,
                _ => null,
            };
        }
    }
}