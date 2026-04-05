
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of workout step - either repeat or one-off
    /// </summary>
    public enum RunningPlannedWorkoutStepType
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
    public static class RunningPlannedWorkoutStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunningPlannedWorkoutStepType value)
        {
            return value switch
            {
                RunningPlannedWorkoutStepType.RepeatStep => "REPEAT_STEP",
                RunningPlannedWorkoutStepType.Step => "STEP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunningPlannedWorkoutStepType? ToEnum(string value)
        {
            return value switch
            {
                "REPEAT_STEP" => RunningPlannedWorkoutStepType.RepeatStep,
                "STEP" => RunningPlannedWorkoutStepType.Step,
                _ => null,
            };
        }
    }
}