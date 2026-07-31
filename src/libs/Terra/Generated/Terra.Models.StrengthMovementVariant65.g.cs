
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant65
    {
        /// <summary>
        /// 
        /// </summary>
        HipHinge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant65Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant65 value)
        {
            return value switch
            {
                StrengthMovementVariant65.HipHinge => "hip_hinge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant65? ToEnum(string value)
        {
            return value switch
            {
                "hip_hinge" => StrengthMovementVariant65.HipHinge,
                _ => null,
            };
        }
    }
}