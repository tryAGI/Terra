
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant97
    {
        /// <summary>
        ///
        /// </summary>
        NeckLateralFlexion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant97Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant97 value)
        {
            return value switch
            {
                StrengthMovementVariant97.NeckLateralFlexion => "neck_lateral_flexion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant97? ToEnum(string value)
        {
            return value switch
            {
                "neck_lateral_flexion" => StrengthMovementVariant97.NeckLateralFlexion,
                _ => null,
            };
        }
    }
}