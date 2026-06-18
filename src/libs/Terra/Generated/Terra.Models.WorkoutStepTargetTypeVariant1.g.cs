
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepTargetTypeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Speed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant1 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant1.Speed => "speed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "speed" => WorkoutStepTargetTypeVariant1.Speed,
                _ => null,
            };
        }
    }
}