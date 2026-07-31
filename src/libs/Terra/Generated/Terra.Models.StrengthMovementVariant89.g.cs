
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant89
    {
        /// <summary>
        /// 
        /// </summary>
        LegSwing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant89Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant89 value)
        {
            return value switch
            {
                StrengthMovementVariant89.LegSwing => "leg_swing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant89? ToEnum(string value)
        {
            return value switch
            {
                "leg_swing" => StrengthMovementVariant89.LegSwing,
                _ => null,
            };
        }
    }
}