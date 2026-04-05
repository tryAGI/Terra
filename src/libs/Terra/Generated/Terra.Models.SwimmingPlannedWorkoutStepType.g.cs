
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of workout step - either repeat or one-off
    /// </summary>
    public enum SwimmingPlannedWorkoutStepType
    {
        /// <summary>
        /// 
        /// </summary>
        RepeatStep,
        /// <summary>
        /// 
        /// </summary>
        Step,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimmingPlannedWorkoutStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimmingPlannedWorkoutStepType value)
        {
            return value switch
            {
                SwimmingPlannedWorkoutStepType.RepeatStep => "REPEAT_STEP",
                SwimmingPlannedWorkoutStepType.Step => "STEP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimmingPlannedWorkoutStepType? ToEnum(string value)
        {
            return value switch
            {
                "REPEAT_STEP" => SwimmingPlannedWorkoutStepType.RepeatStep,
                "STEP" => SwimmingPlannedWorkoutStepType.Step,
                _ => null,
            };
        }
    }
}