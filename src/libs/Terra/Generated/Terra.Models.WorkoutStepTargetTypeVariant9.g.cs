
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepTargetTypeVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        Pace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant9 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant9.Pace => "pace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant9? ToEnum(string value)
        {
            return value switch
            {
                "pace" => WorkoutStepTargetTypeVariant9.Pace,
                _ => null,
            };
        }
    }
}