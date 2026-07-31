
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTempoVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Pulse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTempoVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTempoVariant6 value)
        {
            return value switch
            {
                StrengthTempoVariant6.Pulse => "pulse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTempoVariant6? ToEnum(string value)
        {
            return value switch
            {
                "pulse" => StrengthTempoVariant6.Pulse,
                _ => null,
            };
        }
    }
}