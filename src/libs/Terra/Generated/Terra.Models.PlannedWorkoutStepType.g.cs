
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of workout step - either repeat or one-off
    /// </summary>
    public enum PlannedWorkoutStepType
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
    public static class PlannedWorkoutStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutStepType value)
        {
            return value switch
            {
                PlannedWorkoutStepType.RepeatStep => "REPEAT_STEP",
                PlannedWorkoutStepType.Step => "STEP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutStepType? ToEnum(string value)
        {
            return value switch
            {
                "REPEAT_STEP" => PlannedWorkoutStepType.RepeatStep,
                "STEP" => PlannedWorkoutStepType.Step,
                _ => null,
            };
        }
    }
}