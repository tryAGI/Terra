
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant104
    {
        /// <summary>
        /// 
        /// </summary>
        PlatePinch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant104Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant104 value)
        {
            return value switch
            {
                StrengthMovementVariant104.PlatePinch => "plate_pinch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant104? ToEnum(string value)
        {
            return value switch
            {
                "plate_pinch" => StrengthMovementVariant104.PlatePinch,
                _ => null,
            };
        }
    }
}