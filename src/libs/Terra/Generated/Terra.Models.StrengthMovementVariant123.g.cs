
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant123
    {
        /// <summary>
        /// 
        /// </summary>
        ScapularRetraction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant123Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant123 value)
        {
            return value switch
            {
                StrengthMovementVariant123.ScapularRetraction => "scapular_retraction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant123? ToEnum(string value)
        {
            return value switch
            {
                "scapular_retraction" => StrengthMovementVariant123.ScapularRetraction,
                _ => null,
            };
        }
    }
}