
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant24
    {
        /// <summary>
        ///
        /// </summary>
        ChinUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant24Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant24 value)
        {
            return value switch
            {
                StrengthMovementVariant24.ChinUp => "chin_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant24? ToEnum(string value)
        {
            return value switch
            {
                "chin_up" => StrengthMovementVariant24.ChinUp,
                _ => null,
            };
        }
    }
}