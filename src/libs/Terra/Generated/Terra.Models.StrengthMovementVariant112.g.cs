
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant112
    {
        /// <summary>
        /// 
        /// </summary>
        RearDeltFly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant112Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant112 value)
        {
            return value switch
            {
                StrengthMovementVariant112.RearDeltFly => "rear_delt_fly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant112? ToEnum(string value)
        {
            return value switch
            {
                "rear_delt_fly" => StrengthMovementVariant112.RearDeltFly,
                _ => null,
            };
        }
    }
}