
#nullable enable

namespace Terra
{
    /// <summary>
    /// The back without a part named. Where a source distinguishes the lats or the upper back, `lat` or `upper_back` is reported instead.
    /// </summary>
    public enum StrengthMuscleVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Back,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant4 value)
        {
            return value switch
            {
                StrengthMuscleVariant4.Back => "back",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant4? ToEnum(string value)
        {
            return value switch
            {
                "back" => StrengthMuscleVariant4.Back,
                _ => null,
            };
        }
    }
}