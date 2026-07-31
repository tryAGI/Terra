
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant16
    {
        /// <summary>
        /// 
        /// </summary>
        Triceps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant16 value)
        {
            return value switch
            {
                StrengthMuscleVariant16.Triceps => "triceps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant16? ToEnum(string value)
        {
            return value switch
            {
                "triceps" => StrengthMuscleVariant16.Triceps,
                _ => null,
            };
        }
    }
}