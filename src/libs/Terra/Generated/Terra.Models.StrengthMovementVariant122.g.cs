
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant122
    {
        /// <summary>
        ///
        /// </summary>
        ScapularPushUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant122Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant122 value)
        {
            return value switch
            {
                StrengthMovementVariant122.ScapularPushUp => "scapular_push_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant122? ToEnum(string value)
        {
            return value switch
            {
                "scapular_push_up" => StrengthMovementVariant122.ScapularPushUp,
                _ => null,
            };
        }
    }
}