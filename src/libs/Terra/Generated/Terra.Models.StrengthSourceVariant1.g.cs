
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthSourceVariant1
    {
        /// <summary>
        ///
        /// </summary>
        DeviceDetected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSourceVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSourceVariant1 value)
        {
            return value switch
            {
                StrengthSourceVariant1.DeviceDetected => "device_detected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSourceVariant1? ToEnum(string value)
        {
            return value switch
            {
                "device_detected" => StrengthSourceVariant1.DeviceDetected,
                _ => null,
            };
        }
    }
}