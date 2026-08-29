
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepTargetTypeVariant7
    {
        /// <summary>
        ///
        /// </summary>
        SpeedLap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant7 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant7.SpeedLap => "speed_lap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant7? ToEnum(string value)
        {
            return value switch
            {
                "speed_lap" => WorkoutStepTargetTypeVariant7.SpeedLap,
                _ => null,
            };
        }
    }
}