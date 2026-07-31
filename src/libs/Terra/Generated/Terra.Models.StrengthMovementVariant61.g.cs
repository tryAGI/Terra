
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant61
    {
        /// <summary>
        /// 
        /// </summary>
        HipCircle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant61Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant61 value)
        {
            return value switch
            {
                StrengthMovementVariant61.HipCircle => "hip_circle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant61? ToEnum(string value)
        {
            return value switch
            {
                "hip_circle" => StrengthMovementVariant61.HipCircle,
                _ => null,
            };
        }
    }
}