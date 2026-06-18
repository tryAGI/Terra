
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepIntensityVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Warmup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepIntensityVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepIntensityVariant2 value)
        {
            return value switch
            {
                WorkoutStepIntensityVariant2.Warmup => "warmup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepIntensityVariant2? ToEnum(string value)
        {
            return value switch
            {
                "warmup" => WorkoutStepIntensityVariant2.Warmup,
                _ => null,
            };
        }
    }
}