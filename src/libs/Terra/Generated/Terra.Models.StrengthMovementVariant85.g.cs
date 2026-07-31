
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant85
    {
        /// <summary>
        /// 
        /// </summary>
        LegCycle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant85Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant85 value)
        {
            return value switch
            {
                StrengthMovementVariant85.LegCycle => "leg_cycle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant85? ToEnum(string value)
        {
            return value switch
            {
                "leg_cycle" => StrengthMovementVariant85.LegCycle,
                _ => null,
            };
        }
    }
}