
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant71
    {
        /// <summary>
        /// 
        /// </summary>
        Inchworm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant71Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant71 value)
        {
            return value switch
            {
                StrengthMovementVariant71.Inchworm => "inchworm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant71? ToEnum(string value)
        {
            return value switch
            {
                "inchworm" => StrengthMovementVariant71.Inchworm,
                _ => null,
            };
        }
    }
}