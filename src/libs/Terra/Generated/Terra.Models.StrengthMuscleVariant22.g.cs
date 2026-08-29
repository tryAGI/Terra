
#nullable enable

namespace Terra
{
    /// <summary>
    /// The upper back — rhomboids and mid traps — as distinct from the lats.
    /// </summary>
    public enum StrengthMuscleVariant22
    {
        /// <summary>
        ///
        /// </summary>
        UpperBack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant22Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant22 value)
        {
            return value switch
            {
                StrengthMuscleVariant22.UpperBack => "upper_back",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant22? ToEnum(string value)
        {
            return value switch
            {
                "upper_back" => StrengthMuscleVariant22.UpperBack,
                _ => null,
            };
        }
    }
}