
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant137
    {
        /// <summary>
        /// 
        /// </summary>
        SnatchBalance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant137Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant137 value)
        {
            return value switch
            {
                StrengthMovementVariant137.SnatchBalance => "snatch_balance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant137? ToEnum(string value)
        {
            return value switch
            {
                "snatch_balance" => StrengthMovementVariant137.SnatchBalance,
                _ => null,
            };
        }
    }
}