
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant66
    {
        /// <summary>
        ///
        /// </summary>
        HipThrust,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant66Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant66 value)
        {
            return value switch
            {
                StrengthMovementVariant66.HipThrust => "hip_thrust",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant66? ToEnum(string value)
        {
            return value switch
            {
                "hip_thrust" => StrengthMovementVariant66.HipThrust,
                _ => null,
            };
        }
    }
}