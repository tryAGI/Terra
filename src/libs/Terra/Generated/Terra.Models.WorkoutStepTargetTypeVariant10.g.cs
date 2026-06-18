
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepTargetTypeVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        HeartRateThresholdPercentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant10 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant10.HeartRateThresholdPercentage => "heart_rate_threshold_percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant10? ToEnum(string value)
        {
            return value switch
            {
                "heart_rate_threshold_percentage" => WorkoutStepTargetTypeVariant10.HeartRateThresholdPercentage,
                _ => null,
            };
        }
    }
}