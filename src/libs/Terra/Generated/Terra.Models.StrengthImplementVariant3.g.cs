
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant3
    {
        /// <summary>
        ///
        /// </summary>
        BattleRope,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant3 value)
        {
            return value switch
            {
                StrengthImplementVariant3.BattleRope => "battle_rope",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant3? ToEnum(string value)
        {
            return value switch
            {
                "battle_rope" => StrengthImplementVariant3.BattleRope,
                _ => null,
            };
        }
    }
}