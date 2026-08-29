
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutSportVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Strength,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant4 value)
        {
            return value switch
            {
                WorkoutSportVariant4.Strength => "strength",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant4? ToEnum(string value)
        {
            return value switch
            {
                "strength" => WorkoutSportVariant4.Strength,
                _ => null,
            };
        }
    }
}