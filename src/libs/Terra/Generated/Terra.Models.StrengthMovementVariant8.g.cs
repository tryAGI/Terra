
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        BicepCurl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant8 value)
        {
            return value switch
            {
                StrengthMovementVariant8.BicepCurl => "bicep_curl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant8? ToEnum(string value)
        {
            return value switch
            {
                "bicep_curl" => StrengthMovementVariant8.BicepCurl,
                _ => null,
            };
        }
    }
}