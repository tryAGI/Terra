
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant53
    {
        /// <summary>
        ///
        /// </summary>
        HandstandWalk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant53Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant53 value)
        {
            return value switch
            {
                StrengthMovementVariant53.HandstandWalk => "handstand_walk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant53? ToEnum(string value)
        {
            return value switch
            {
                "handstand_walk" => StrengthMovementVariant53.HandstandWalk,
                _ => null,
            };
        }
    }
}