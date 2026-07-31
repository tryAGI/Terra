
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthStanceVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Crossover,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthStanceVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthStanceVariant1 value)
        {
            return value switch
            {
                StrengthStanceVariant1.Crossover => "crossover",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthStanceVariant1? ToEnum(string value)
        {
            return value switch
            {
                "crossover" => StrengthStanceVariant1.Crossover,
                _ => null,
            };
        }
    }
}