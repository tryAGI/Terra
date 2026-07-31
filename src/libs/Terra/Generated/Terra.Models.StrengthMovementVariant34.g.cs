
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant34
    {
        /// <summary>
        /// 
        /// </summary>
        DepthJump,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant34Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant34 value)
        {
            return value switch
            {
                StrengthMovementVariant34.DepthJump => "depth_jump",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant34? ToEnum(string value)
        {
            return value switch
            {
                "depth_jump" => StrengthMovementVariant34.DepthJump,
                _ => null,
            };
        }
    }
}