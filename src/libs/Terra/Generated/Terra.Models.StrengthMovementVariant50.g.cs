
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant50
    {
        /// <summary>
        /// 
        /// </summary>
        HandWalk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant50Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant50 value)
        {
            return value switch
            {
                StrengthMovementVariant50.HandWalk => "hand_walk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant50? ToEnum(string value)
        {
            return value switch
            {
                "hand_walk" => StrengthMovementVariant50.HandWalk,
                _ => null,
            };
        }
    }
}