
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepTargetTypeVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        HeartRateLap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant8 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant8.HeartRateLap => "heart_rate_lap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant8? ToEnum(string value)
        {
            return value switch
            {
                "heart_rate_lap" => WorkoutStepTargetTypeVariant8.HeartRateLap,
                _ => null,
            };
        }
    }
}