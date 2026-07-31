
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant59
    {
        /// <summary>
        /// 
        /// </summary>
        HipAbduction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant59Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant59 value)
        {
            return value switch
            {
                StrengthMovementVariant59.HipAbduction => "hip_abduction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant59? ToEnum(string value)
        {
            return value switch
            {
                "hip_abduction" => StrengthMovementVariant59.HipAbduction,
                _ => null,
            };
        }
    }
}