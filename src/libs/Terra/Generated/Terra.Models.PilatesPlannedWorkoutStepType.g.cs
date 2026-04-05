
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of workout step - either repeat or one-off
    /// </summary>
    public enum PilatesPlannedWorkoutStepType
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
    public static class PilatesPlannedWorkoutStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PilatesPlannedWorkoutStepType value)
        {
            return value switch
            {
                PilatesPlannedWorkoutStepType.RepeatStep => "REPEAT_STEP",
                PilatesPlannedWorkoutStepType.Step => "STEP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PilatesPlannedWorkoutStepType? ToEnum(string value)
        {
            return value switch
            {
                "REPEAT_STEP" => PilatesPlannedWorkoutStepType.RepeatStep,
                "STEP" => PilatesPlannedWorkoutStepType.Step,
                _ => null,
            };
        }
    }
}