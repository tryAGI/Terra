
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutSportVariant15
    {
        /// <summary>
        ///
        /// </summary>
        StairClimbing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant15Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant15 value)
        {
            return value switch
            {
                WorkoutSportVariant15.StairClimbing => "stair_climbing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant15? ToEnum(string value)
        {
            return value switch
            {
                "stair_climbing" => WorkoutSportVariant15.StairClimbing,
                _ => null,
            };
        }
    }
}