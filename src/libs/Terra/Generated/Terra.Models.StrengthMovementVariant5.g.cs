
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        BattleRopeSlam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant5 value)
        {
            return value switch
            {
                StrengthMovementVariant5.BattleRopeSlam => "battle_rope_slam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant5? ToEnum(string value)
        {
            return value switch
            {
                "battle_rope_slam" => StrengthMovementVariant5.BattleRopeSlam,
                _ => null,
            };
        }
    }
}