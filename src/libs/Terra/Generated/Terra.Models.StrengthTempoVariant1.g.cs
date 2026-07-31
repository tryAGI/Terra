
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTempoVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Eccentric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTempoVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTempoVariant1 value)
        {
            return value switch
            {
                StrengthTempoVariant1.Eccentric => "eccentric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTempoVariant1? ToEnum(string value)
        {
            return value switch
            {
                "eccentric" => StrengthTempoVariant1.Eccentric,
                _ => null,
            };
        }
    }
}