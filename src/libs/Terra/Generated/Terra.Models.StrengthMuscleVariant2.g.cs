
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMuscleVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Abs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant2 value)
        {
            return value switch
            {
                StrengthMuscleVariant2.Abs => "abs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant2? ToEnum(string value)
        {
            return value switch
            {
                "abs" => StrengthMuscleVariant2.Abs,
                _ => null,
            };
        }
    }
}