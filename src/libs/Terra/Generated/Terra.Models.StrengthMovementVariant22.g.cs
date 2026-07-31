
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        ChestFly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant22Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant22 value)
        {
            return value switch
            {
                StrengthMovementVariant22.ChestFly => "chest_fly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant22? ToEnum(string value)
        {
            return value switch
            {
                "chest_fly" => StrengthMovementVariant22.ChestFly,
                _ => null,
            };
        }
    }
}