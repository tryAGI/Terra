
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of workout step - either repeat or one-off
    /// </summary>
    public enum StrengthPlannedWorkoutStepType
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
    public static class StrengthPlannedWorkoutStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPlannedWorkoutStepType value)
        {
            return value switch
            {
                StrengthPlannedWorkoutStepType.RepeatStep => "REPEAT_STEP",
                StrengthPlannedWorkoutStepType.Step => "STEP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPlannedWorkoutStepType? ToEnum(string value)
        {
            return value switch
            {
                "REPEAT_STEP" => StrengthPlannedWorkoutStepType.RepeatStep,
                "STEP" => StrengthPlannedWorkoutStepType.Step,
                _ => null,
            };
        }
    }
}