
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant173
    {
        /// <summary>
        /// 
        /// </summary>
        WristCurl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant173Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant173 value)
        {
            return value switch
            {
                StrengthMovementVariant173.WristCurl => "wrist_curl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant173? ToEnum(string value)
        {
            return value switch
            {
                "wrist_curl" => StrengthMovementVariant173.WristCurl,
                _ => null,
            };
        }
    }
}