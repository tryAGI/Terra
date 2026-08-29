
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthLateralityVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Alternating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthLateralityVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthLateralityVariant1 value)
        {
            return value switch
            {
                StrengthLateralityVariant1.Alternating => "alternating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthLateralityVariant1? ToEnum(string value)
        {
            return value switch
            {
                "alternating" => StrengthLateralityVariant1.Alternating,
                _ => null,
            };
        }
    }
}