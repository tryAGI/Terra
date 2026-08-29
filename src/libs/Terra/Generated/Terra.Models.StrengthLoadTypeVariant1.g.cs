
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthLoadTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Assisted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthLoadTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthLoadTypeVariant1 value)
        {
            return value switch
            {
                StrengthLoadTypeVariant1.Assisted => "assisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthLoadTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "assisted" => StrengthLoadTypeVariant1.Assisted,
                _ => null,
            };
        }
    }
}