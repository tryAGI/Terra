
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant76
    {
        /// <summary>
        /// 
        /// </summary>
        Kick,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant76Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant76 value)
        {
            return value switch
            {
                StrengthMovementVariant76.Kick => "kick",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant76? ToEnum(string value)
        {
            return value switch
            {
                "kick" => StrengthMovementVariant76.Kick,
                _ => null,
            };
        }
    }
}