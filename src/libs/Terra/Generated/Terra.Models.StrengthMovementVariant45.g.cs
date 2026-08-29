
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant45
    {
        /// <summary>
        ///
        /// </summary>
        FrontRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant45Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant45 value)
        {
            return value switch
            {
                StrengthMovementVariant45.FrontRaise => "front_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant45? ToEnum(string value)
        {
            return value switch
            {
                "front_raise" => StrengthMovementVariant45.FrontRaise,
                _ => null,
            };
        }
    }
}