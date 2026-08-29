
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant87
    {
        /// <summary>
        ///
        /// </summary>
        LegPress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant87Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant87 value)
        {
            return value switch
            {
                StrengthMovementVariant87.LegPress => "leg_press",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant87? ToEnum(string value)
        {
            return value switch
            {
                "leg_press" => StrengthMovementVariant87.LegPress,
                _ => null,
            };
        }
    }
}