
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepTargetTypeVariant11
    {
        /// <summary>
        ///
        /// </summary>
        HeartRateMaxPercentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant11 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant11.HeartRateMaxPercentage => "heart_rate_max_percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant11? ToEnum(string value)
        {
            return value switch
            {
                "heart_rate_max_percentage" => WorkoutStepTargetTypeVariant11.HeartRateMaxPercentage,
                _ => null,
            };
        }
    }
}