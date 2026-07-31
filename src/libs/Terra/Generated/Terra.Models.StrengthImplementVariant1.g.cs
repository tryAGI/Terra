
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthImplementVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Band,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant1 value)
        {
            return value switch
            {
                StrengthImplementVariant1.Band => "band",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant1? ToEnum(string value)
        {
            return value switch
            {
                "band" => StrengthImplementVariant1.Band,
                _ => null,
            };
        }
    }
}