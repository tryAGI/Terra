
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTargetVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Abs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant1 value)
        {
            return value switch
            {
                StrengthTargetVariant1.Abs => "abs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant1? ToEnum(string value)
        {
            return value switch
            {
                "abs" => StrengthTargetVariant1.Abs,
                _ => null,
            };
        }
    }
}