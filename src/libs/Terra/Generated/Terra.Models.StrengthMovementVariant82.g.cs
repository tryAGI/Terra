
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant82
    {
        /// <summary>
        /// 
        /// </summary>
        LateralWalk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant82Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant82 value)
        {
            return value switch
            {
                StrengthMovementVariant82.LateralWalk => "lateral_walk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant82? ToEnum(string value)
        {
            return value switch
            {
                "lateral_walk" => StrengthMovementVariant82.LateralWalk,
                _ => null,
            };
        }
    }
}