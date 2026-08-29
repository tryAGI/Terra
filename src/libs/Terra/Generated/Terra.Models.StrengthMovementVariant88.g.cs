
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant88
    {
        /// <summary>
        ///
        /// </summary>
        LegRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant88Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant88 value)
        {
            return value switch
            {
                StrengthMovementVariant88.LegRaise => "leg_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant88? ToEnum(string value)
        {
            return value switch
            {
                "leg_raise" => StrengthMovementVariant88.LegRaise,
                _ => null,
            };
        }
    }
}