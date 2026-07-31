
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        ArmCircle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant2 value)
        {
            return value switch
            {
                StrengthMovementVariant2.ArmCircle => "arm_circle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant2? ToEnum(string value)
        {
            return value switch
            {
                "arm_circle" => StrengthMovementVariant2.ArmCircle,
                _ => null,
            };
        }
    }
}