
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant62
    {
        /// <summary>
        /// 
        /// </summary>
        HipDrop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant62Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant62 value)
        {
            return value switch
            {
                StrengthMovementVariant62.HipDrop => "hip_drop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant62? ToEnum(string value)
        {
            return value switch
            {
                "hip_drop" => StrengthMovementVariant62.HipDrop,
                _ => null,
            };
        }
    }
}