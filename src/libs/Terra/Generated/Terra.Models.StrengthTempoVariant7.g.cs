
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTempoVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        TempoSlow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTempoVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTempoVariant7 value)
        {
            return value switch
            {
                StrengthTempoVariant7.TempoSlow => "tempo_slow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTempoVariant7? ToEnum(string value)
        {
            return value switch
            {
                "tempo_slow" => StrengthTempoVariant7.TempoSlow,
                _ => null,
            };
        }
    }
}