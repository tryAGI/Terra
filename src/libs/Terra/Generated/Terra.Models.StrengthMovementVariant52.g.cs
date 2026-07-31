
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant52
    {
        /// <summary>
        /// 
        /// </summary>
        HandstandPushUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant52Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant52 value)
        {
            return value switch
            {
                StrengthMovementVariant52.HandstandPushUp => "handstand_push_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant52? ToEnum(string value)
        {
            return value switch
            {
                "handstand_push_up" => StrengthMovementVariant52.HandstandPushUp,
                _ => null,
            };
        }
    }
}