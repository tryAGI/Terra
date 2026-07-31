
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthProgrammeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Pregnancy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthProgrammeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthProgrammeVariant1 value)
        {
            return value switch
            {
                StrengthProgrammeVariant1.Pregnancy => "pregnancy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthProgrammeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "pregnancy" => StrengthProgrammeVariant1.Pregnancy,
                _ => null,
            };
        }
    }
}