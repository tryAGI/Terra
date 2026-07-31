
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant84
    {
        /// <summary>
        /// 
        /// </summary>
        LegCurl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant84Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant84 value)
        {
            return value switch
            {
                StrengthMovementVariant84.LegCurl => "leg_curl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant84? ToEnum(string value)
        {
            return value switch
            {
                "leg_curl" => StrengthMovementVariant84.LegCurl,
                _ => null,
            };
        }
    }
}