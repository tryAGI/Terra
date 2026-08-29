
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMuscleVariant20
    {
        /// <summary>
        ///
        /// </summary>
        Trapezius,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant20Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant20 value)
        {
            return value switch
            {
                StrengthMuscleVariant20.Trapezius => "trapezius",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant20? ToEnum(string value)
        {
            return value switch
            {
                "trapezius" => StrengthMuscleVariant20.Trapezius,
                _ => null,
            };
        }
    }
}