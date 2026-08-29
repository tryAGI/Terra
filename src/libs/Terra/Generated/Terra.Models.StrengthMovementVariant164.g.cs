
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant164
    {
        /// <summary>
        ///
        /// </summary>
        UprightRow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant164Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant164 value)
        {
            return value switch
            {
                StrengthMovementVariant164.UprightRow => "upright_row",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant164? ToEnum(string value)
        {
            return value switch
            {
                "upright_row" => StrengthMovementVariant164.UprightRow,
                _ => null,
            };
        }
    }
}