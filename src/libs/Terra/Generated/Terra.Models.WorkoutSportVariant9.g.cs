
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutSportVariant9
    {
        /// <summary>
        ///
        /// </summary>
        TrailRunning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant9 value)
        {
            return value switch
            {
                WorkoutSportVariant9.TrailRunning => "trail_running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant9? ToEnum(string value)
        {
            return value switch
            {
                "trail_running" => WorkoutSportVariant9.TrailRunning,
                _ => null,
            };
        }
    }
}