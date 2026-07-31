
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Abductors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant1 value)
        {
            return value switch
            {
                StrengthMuscleVariant1.Abductors => "abductors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant1? ToEnum(string value)
        {
            return value switch
            {
                "abductors" => StrengthMuscleVariant1.Abductors,
                _ => null,
            };
        }
    }
}