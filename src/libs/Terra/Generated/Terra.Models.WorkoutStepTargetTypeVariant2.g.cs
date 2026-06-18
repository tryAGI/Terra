
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepTargetTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        HeartRate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant2 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant2.HeartRate => "heart_rate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "heart_rate" => WorkoutStepTargetTypeVariant2.HeartRate,
                _ => null,
            };
        }
    }
}