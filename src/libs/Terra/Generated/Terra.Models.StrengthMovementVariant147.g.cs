
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant147
    {
        /// <summary>
        /// 
        /// </summary>
        StraightArmPulldown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant147Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant147 value)
        {
            return value switch
            {
                StrengthMovementVariant147.StraightArmPulldown => "straight_arm_pulldown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant147? ToEnum(string value)
        {
            return value switch
            {
                "straight_arm_pulldown" => StrengthMovementVariant147.StraightArmPulldown,
                _ => null,
            };
        }
    }
}