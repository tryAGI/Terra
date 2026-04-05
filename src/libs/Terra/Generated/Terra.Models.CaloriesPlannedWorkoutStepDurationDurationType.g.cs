
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum CaloriesPlannedWorkoutStepDurationDurationType
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
    public static class CaloriesPlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaloriesPlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                CaloriesPlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                CaloriesPlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                CaloriesPlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                CaloriesPlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                CaloriesPlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                CaloriesPlannedWorkoutStepDurationDurationType.Open => "OPEN",
                CaloriesPlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                CaloriesPlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                CaloriesPlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                CaloriesPlannedWorkoutStepDurationDurationType.Reps => "REPS",
                CaloriesPlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                CaloriesPlannedWorkoutStepDurationDurationType.Time => "TIME",
                CaloriesPlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaloriesPlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => CaloriesPlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => CaloriesPlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => CaloriesPlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => CaloriesPlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => CaloriesPlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => CaloriesPlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => CaloriesPlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => CaloriesPlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => CaloriesPlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => CaloriesPlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => CaloriesPlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => CaloriesPlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => CaloriesPlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}