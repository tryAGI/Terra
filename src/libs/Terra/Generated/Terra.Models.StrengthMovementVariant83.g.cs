
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant83
    {
        /// <summary>
        /// 
        /// </summary>
        LegCircle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant83Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant83 value)
        {
            return value switch
            {
                StrengthMovementVariant83.LegCircle => "leg_circle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant83? ToEnum(string value)
        {
            return value switch
            {
                "leg_circle" => StrengthMovementVariant83.LegCircle,
                _ => null,
            };
        }
    }
}