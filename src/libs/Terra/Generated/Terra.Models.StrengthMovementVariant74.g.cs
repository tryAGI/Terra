
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant74
    {
        /// <summary>
        /// 
        /// </summary>
        JumpRope,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant74Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant74 value)
        {
            return value switch
            {
                StrengthMovementVariant74.JumpRope => "jump_rope",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant74? ToEnum(string value)
        {
            return value switch
            {
                "jump_rope" => StrengthMovementVariant74.JumpRope,
                _ => null,
            };
        }
    }
}