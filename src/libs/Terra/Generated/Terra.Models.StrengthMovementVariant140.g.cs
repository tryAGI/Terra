
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant140
    {
        /// <summary>
        /// 
        /// </summary>
        StairClimb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant140Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant140 value)
        {
            return value switch
            {
                StrengthMovementVariant140.StairClimb => "stair_climb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant140? ToEnum(string value)
        {
            return value switch
            {
                "stair_climb" => StrengthMovementVariant140.StairClimb,
                _ => null,
            };
        }
    }
}