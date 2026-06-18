
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepTargetTypeVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Power,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant5 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant5.Power => "power",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant5? ToEnum(string value)
        {
            return value switch
            {
                "power" => WorkoutStepTargetTypeVariant5.Power,
                _ => null,
            };
        }
    }
}