
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant44
    {
        /// <summary>
        /// 
        /// </summary>
        FrogKick,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant44Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant44 value)
        {
            return value switch
            {
                StrengthMovementVariant44.FrogKick => "frog_kick",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant44? ToEnum(string value)
        {
            return value switch
            {
                "frog_kick" => StrengthMovementVariant44.FrogKick,
                _ => null,
            };
        }
    }
}