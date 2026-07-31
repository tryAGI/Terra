
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant15
    {
        /// <summary>
        /// 
        /// </summary>
        BroadJump,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant15Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant15 value)
        {
            return value switch
            {
                StrengthMovementVariant15.BroadJump => "broad_jump",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant15? ToEnum(string value)
        {
            return value switch
            {
                "broad_jump" => StrengthMovementVariant15.BroadJump,
                _ => null,
            };
        }
    }
}