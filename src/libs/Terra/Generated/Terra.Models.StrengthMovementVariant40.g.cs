
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant40
    {
        /// <summary>
        /// 
        /// </summary>
        FarmersCarry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant40Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant40 value)
        {
            return value switch
            {
                StrengthMovementVariant40.FarmersCarry => "farmers_carry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant40? ToEnum(string value)
        {
            return value switch
            {
                "farmers_carry" => StrengthMovementVariant40.FarmersCarry,
                _ => null,
            };
        }
    }
}