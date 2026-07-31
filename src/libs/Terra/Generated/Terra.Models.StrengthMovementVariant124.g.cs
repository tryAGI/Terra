
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant124
    {
        /// <summary>
        /// 
        /// </summary>
        ScissorKick,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant124Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant124 value)
        {
            return value switch
            {
                StrengthMovementVariant124.ScissorKick => "scissor_kick",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant124? ToEnum(string value)
        {
            return value switch
            {
                "scissor_kick" => StrengthMovementVariant124.ScissorKick,
                _ => null,
            };
        }
    }
}