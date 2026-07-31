
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant141
    {
        /// <summary>
        /// 
        /// </summary>
        StarJump,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant141Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant141 value)
        {
            return value switch
            {
                StrengthMovementVariant141.StarJump => "star_jump",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant141? ToEnum(string value)
        {
            return value switch
            {
                "star_jump" => StrengthMovementVariant141.StarJump,
                _ => null,
            };
        }
    }
}