
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMuscleVariant21
    {
        /// <summary>
        ///
        /// </summary>
        Triceps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant21Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant21 value)
        {
            return value switch
            {
                StrengthMuscleVariant21.Triceps => "triceps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant21? ToEnum(string value)
        {
            return value switch
            {
                "triceps" => StrengthMuscleVariant21.Triceps,
                _ => null,
            };
        }
    }
}