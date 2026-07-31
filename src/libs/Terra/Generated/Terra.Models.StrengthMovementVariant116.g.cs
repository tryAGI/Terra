
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant116
    {
        /// <summary>
        /// 
        /// </summary>
        RopeClimb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant116Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant116 value)
        {
            return value switch
            {
                StrengthMovementVariant116.RopeClimb => "rope_climb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant116? ToEnum(string value)
        {
            return value switch
            {
                "rope_climb" => StrengthMovementVariant116.RopeClimb,
                _ => null,
            };
        }
    }
}