
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepTargetTypeVariant18
    {
        /// <summary>
        ///
        /// </summary>
        HeartRateZone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant18Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant18 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant18.HeartRateZone => "heart_rate_zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant18? ToEnum(string value)
        {
            return value switch
            {
                "heart_rate_zone" => WorkoutStepTargetTypeVariant18.HeartRateZone,
                _ => null,
            };
        }
    }
}