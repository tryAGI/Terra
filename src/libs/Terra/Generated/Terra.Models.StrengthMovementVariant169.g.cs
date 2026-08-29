
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant169
    {
        /// <summary>
        ///
        /// </summary>
        Walkout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant169Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant169 value)
        {
            return value switch
            {
                StrengthMovementVariant169.Walkout => "walkout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant169? ToEnum(string value)
        {
            return value switch
            {
                "walkout" => StrengthMovementVariant169.Walkout,
                _ => null,
            };
        }
    }
}