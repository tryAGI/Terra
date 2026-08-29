
#nullable enable

namespace Terra
{
    /// <summary>
    /// Tibialis anterior. Its own group — not part of the calves, which it opposes.
    /// </summary>
    public enum StrengthMuscleVariant19
    {
        /// <summary>
        ///
        /// </summary>
        Tibialis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant19Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant19 value)
        {
            return value switch
            {
                StrengthMuscleVariant19.Tibialis => "tibialis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant19? ToEnum(string value)
        {
            return value switch
            {
                "tibialis" => StrengthMuscleVariant19.Tibialis,
                _ => null,
            };
        }
    }
}