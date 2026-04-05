
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum StepsPlannedWorkoutStepDurationDurationType
    {
        /// <summary>
        /// 
        /// </summary>
        Calories,
        /// <summary>
        /// 
        /// </summary>
        DistanceMeters,
        /// <summary>
        /// 
        /// </summary>
        FixedRest,
        /// <summary>
        /// 
        /// </summary>
        HrGreaterThan,
        /// <summary>
        /// 
        /// </summary>
        HrLessThan,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        PowerGreaterThan,
        /// <summary>
        /// 
        /// </summary>
        PowerLessThan,
        /// <summary>
        /// 
        /// </summary>
        RepetitionTime,
        /// <summary>
        /// 
        /// </summary>
        Reps,
        /// <summary>
        /// 
        /// </summary>
        Steps,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        TimeAtValidCda,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepsPlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepsPlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                StepsPlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                StepsPlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                StepsPlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                StepsPlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                StepsPlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                StepsPlannedWorkoutStepDurationDurationType.Open => "OPEN",
                StepsPlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                StepsPlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                StepsPlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                StepsPlannedWorkoutStepDurationDurationType.Reps => "REPS",
                StepsPlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                StepsPlannedWorkoutStepDurationDurationType.Time => "TIME",
                StepsPlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepsPlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => StepsPlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => StepsPlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => StepsPlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => StepsPlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => StepsPlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => StepsPlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => StepsPlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => StepsPlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => StepsPlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => StepsPlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => StepsPlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => StepsPlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => StepsPlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}