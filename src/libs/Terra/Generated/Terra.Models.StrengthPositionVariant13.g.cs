
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthPositionVariant13
    {
        /// <summary>
        ///
        /// </summary>
        Prone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant13 value)
        {
            return value switch
            {
                StrengthPositionVariant13.Prone => "prone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant13? ToEnum(string value)
        {
            return value switch
            {
                "prone" => StrengthPositionVariant13.Prone,
                _ => null,
            };
        }
    }
}