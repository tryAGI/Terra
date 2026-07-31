
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant125
    {
        /// <summary>
        /// 
        /// </summary>
        ShoulderExternalRotation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant125Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant125 value)
        {
            return value switch
            {
                StrengthMovementVariant125.ShoulderExternalRotation => "shoulder_external_rotation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant125? ToEnum(string value)
        {
            return value switch
            {
                "shoulder_external_rotation" => StrengthMovementVariant125.ShoulderExternalRotation,
                _ => null,
            };
        }
    }
}