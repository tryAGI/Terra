
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant161
    {
        /// <summary>
        ///
        /// </summary>
        TrunkLateralFlexion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant161Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant161 value)
        {
            return value switch
            {
                StrengthMovementVariant161.TrunkLateralFlexion => "trunk_lateral_flexion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant161? ToEnum(string value)
        {
            return value switch
            {
                "trunk_lateral_flexion" => StrengthMovementVariant161.TrunkLateralFlexion,
                _ => null,
            };
        }
    }
}