
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant68
    {
        /// <summary>
        /// 
        /// </summary>
        HollowHold,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant68Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant68 value)
        {
            return value switch
            {
                StrengthMovementVariant68.HollowHold => "hollow_hold",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant68? ToEnum(string value)
        {
            return value switch
            {
                "hollow_hold" => StrengthMovementVariant68.HollowHold,
                _ => null,
            };
        }
    }
}