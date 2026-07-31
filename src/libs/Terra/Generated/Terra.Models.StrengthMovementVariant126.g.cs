
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant126
    {
        /// <summary>
        /// 
        /// </summary>
        ShoulderInternalRotation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant126Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant126 value)
        {
            return value switch
            {
                StrengthMovementVariant126.ShoulderInternalRotation => "shoulder_internal_rotation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant126? ToEnum(string value)
        {
            return value switch
            {
                "shoulder_internal_rotation" => StrengthMovementVariant126.ShoulderInternalRotation,
                _ => null,
            };
        }
    }
}