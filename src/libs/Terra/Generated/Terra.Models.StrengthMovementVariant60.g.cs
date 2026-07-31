
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant60
    {
        /// <summary>
        /// 
        /// </summary>
        HipAdduction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant60Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant60 value)
        {
            return value switch
            {
                StrengthMovementVariant60.HipAdduction => "hip_adduction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant60? ToEnum(string value)
        {
            return value switch
            {
                "hip_adduction" => StrengthMovementVariant60.HipAdduction,
                _ => null,
            };
        }
    }
}