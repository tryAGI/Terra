
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepTargetTypeVariant12
    {
        /// <summary>
        ///
        /// </summary>
        SpeedPercentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant12 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant12.SpeedPercentage => "speed_percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant12? ToEnum(string value)
        {
            return value switch
            {
                "speed_percentage" => WorkoutStepTargetTypeVariant12.SpeedPercentage,
                _ => null,
            };
        }
    }
}