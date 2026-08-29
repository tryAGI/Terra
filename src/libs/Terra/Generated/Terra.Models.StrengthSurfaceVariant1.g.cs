
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthSurfaceVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Bench,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSurfaceVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSurfaceVariant1 value)
        {
            return value switch
            {
                StrengthSurfaceVariant1.Bench => "bench",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSurfaceVariant1? ToEnum(string value)
        {
            return value switch
            {
                "bench" => StrengthSurfaceVariant1.Bench,
                _ => null,
            };
        }
    }
}