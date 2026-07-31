
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant15
    {
        /// <summary>
        /// 
        /// </summary>
        Trapezius,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant15Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant15 value)
        {
            return value switch
            {
                StrengthMuscleVariant15.Trapezius => "trapezius",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant15? ToEnum(string value)
        {
            return value switch
            {
                "trapezius" => StrengthMuscleVariant15.Trapezius,
                _ => null,
            };
        }
    }
}