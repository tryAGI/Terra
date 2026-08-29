
#nullable enable

namespace Terra
{
    /// <summary>
    /// Serratus anterior. Its own group — not part of the chest.
    /// </summary>
    public enum StrengthMuscleVariant17
    {
        /// <summary>
        ///
        /// </summary>
        Serratus,
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
                StrengthMuscleVariant17.Serratus => "serratus",
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
                "serratus" => StrengthMuscleVariant17.Serratus,
                _ => null,
            };
        }
    }
}