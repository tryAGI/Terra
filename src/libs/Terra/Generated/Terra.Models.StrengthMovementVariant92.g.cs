
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant92
    {
        /// <summary>
        ///
        /// </summary>
        MonsterWalk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant92Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant92 value)
        {
            return value switch
            {
                StrengthMovementVariant92.MonsterWalk => "monster_walk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant92? ToEnum(string value)
        {
            return value switch
            {
                "monster_walk" => StrengthMovementVariant92.MonsterWalk,
                _ => null,
            };
        }
    }
}