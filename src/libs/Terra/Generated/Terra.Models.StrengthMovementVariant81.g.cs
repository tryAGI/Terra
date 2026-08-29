
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant81
    {
        /// <summary>
        ///
        /// </summary>
        LateralRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant81Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant81 value)
        {
            return value switch
            {
                StrengthMovementVariant81.LateralRaise => "lateral_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant81? ToEnum(string value)
        {
            return value switch
            {
                "lateral_raise" => StrengthMovementVariant81.LateralRaise,
                _ => null,
            };
        }
    }
}