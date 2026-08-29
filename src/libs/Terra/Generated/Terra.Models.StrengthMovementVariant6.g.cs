
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant6
    {
        /// <summary>
        ///
        /// </summary>
        BattleRopeWave,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant6 value)
        {
            return value switch
            {
                StrengthMovementVariant6.BattleRopeWave => "battle_rope_wave",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant6? ToEnum(string value)
        {
            return value switch
            {
                "battle_rope_wave" => StrengthMovementVariant6.BattleRopeWave,
                _ => null,
            };
        }
    }
}