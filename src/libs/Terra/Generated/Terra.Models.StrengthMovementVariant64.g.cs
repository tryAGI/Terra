
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant64
    {
        /// <summary>
        ///
        /// </summary>
        HipFlexion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant64Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant64 value)
        {
            return value switch
            {
                StrengthMovementVariant64.HipFlexion => "hip_flexion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant64? ToEnum(string value)
        {
            return value switch
            {
                "hip_flexion" => StrengthMovementVariant64.HipFlexion,
                _ => null,
            };
        }
    }
}