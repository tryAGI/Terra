
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant156
    {
        /// <summary>
        ///
        /// </summary>
        TibialisRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant156Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant156 value)
        {
            return value switch
            {
                StrengthMovementVariant156.TibialisRaise => "tibialis_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant156? ToEnum(string value)
        {
            return value switch
            {
                "tibialis_raise" => StrengthMovementVariant156.TibialisRaise,
                _ => null,
            };
        }
    }
}