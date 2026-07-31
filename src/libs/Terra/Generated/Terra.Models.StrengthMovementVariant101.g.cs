
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant101
    {
        /// <summary>
        /// 
        /// </summary>
        PikeUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant101Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant101 value)
        {
            return value switch
            {
                StrengthMovementVariant101.PikeUp => "pike_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant101? ToEnum(string value)
        {
            return value switch
            {
                "pike_up" => StrengthMovementVariant101.PikeUp,
                _ => null,
            };
        }
    }
}