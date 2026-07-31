
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant18
    {
        /// <summary>
        /// 
        /// </summary>
        Triceps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant18Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant18 value)
        {
            return value switch
            {
                StrengthMuscleVariant18.Triceps => "triceps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant18? ToEnum(string value)
        {
            return value switch
            {
                "triceps" => StrengthMuscleVariant18.Triceps,
                _ => null,
            };
        }
    }
}