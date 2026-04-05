
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of workout step - either repeat or one-off
    /// </summary>
    public enum CardioPlannedWorkoutStepType
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
    public static class CardioPlannedWorkoutStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CardioPlannedWorkoutStepType value)
        {
            return value switch
            {
                CardioPlannedWorkoutStepType.RepeatStep => "REPEAT_STEP",
                CardioPlannedWorkoutStepType.Step => "STEP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CardioPlannedWorkoutStepType? ToEnum(string value)
        {
            return value switch
            {
                "REPEAT_STEP" => CardioPlannedWorkoutStepType.RepeatStep,
                "STEP" => CardioPlannedWorkoutStepType.Step,
                _ => null,
            };
        }
    }
}