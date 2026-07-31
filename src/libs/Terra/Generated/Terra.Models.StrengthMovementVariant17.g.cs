
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant17
    {
        /// <summary>
        /// 
        /// </summary>
        ButtKick,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant17Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant17 value)
        {
            return value switch
            {
                StrengthMovementVariant17.ButtKick => "butt_kick",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant17? ToEnum(string value)
        {
            return value switch
            {
                "butt_kick" => StrengthMovementVariant17.ButtKick,
                _ => null,
            };
        }
    }
}