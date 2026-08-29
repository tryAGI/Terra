
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMuscleVariant10
    {
        /// <summary>
        ///
        /// </summary>
        Hamstrings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant10 value)
        {
            return value switch
            {
                StrengthMuscleVariant10.Hamstrings => "hamstrings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant10? ToEnum(string value)
        {
            return value switch
            {
                "hamstrings" => StrengthMuscleVariant10.Hamstrings,
                _ => null,
            };
        }
    }
}