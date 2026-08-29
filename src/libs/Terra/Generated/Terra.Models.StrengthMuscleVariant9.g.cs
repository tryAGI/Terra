
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMuscleVariant9
    {
        /// <summary>
        ///
        /// </summary>
        Glutes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant9 value)
        {
            return value switch
            {
                StrengthMuscleVariant9.Glutes => "glutes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant9? ToEnum(string value)
        {
            return value switch
            {
                "glutes" => StrengthMuscleVariant9.Glutes,
                _ => null,
            };
        }
    }
}