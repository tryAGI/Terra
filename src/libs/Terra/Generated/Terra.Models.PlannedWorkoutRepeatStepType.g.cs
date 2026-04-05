
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of workout step - either repeat or one-off
    /// </summary>
    public enum PlannedWorkoutRepeatStepType
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
    public static class PlannedWorkoutRepeatStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutRepeatStepType value)
        {
            return value switch
            {
                PlannedWorkoutRepeatStepType.RepeatStep => "REPEAT_STEP",
                PlannedWorkoutRepeatStepType.Step => "STEP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutRepeatStepType? ToEnum(string value)
        {
            return value switch
            {
                "REPEAT_STEP" => PlannedWorkoutRepeatStepType.RepeatStep,
                "STEP" => PlannedWorkoutRepeatStepType.Step,
                _ => null,
            };
        }
    }
}