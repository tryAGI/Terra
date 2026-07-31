
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant29
    {
        /// <summary>
        /// 
        /// </summary>
        Complex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant29Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant29 value)
        {
            return value switch
            {
                StrengthMovementVariant29.Complex => "complex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant29? ToEnum(string value)
        {
            return value switch
            {
                "complex" => StrengthMovementVariant29.Complex,
                _ => null,
            };
        }
    }
}