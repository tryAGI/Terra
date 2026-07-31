
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant17
    {
        /// <summary>
        /// 
        /// </summary>
        Trapezius,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant17Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant17 value)
        {
            return value switch
            {
                StrengthMuscleVariant17.Trapezius => "trapezius",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant17? ToEnum(string value)
        {
            return value switch
            {
                "trapezius" => StrengthMuscleVariant17.Trapezius,
                _ => null,
            };
        }
    }
}