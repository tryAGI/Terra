
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum PlannedWorkoutStepDurationDurationType
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
    public static class PlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                PlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                PlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                PlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                PlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                PlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                PlannedWorkoutStepDurationDurationType.Open => "OPEN",
                PlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                PlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                PlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                PlannedWorkoutStepDurationDurationType.Reps => "REPS",
                PlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                PlannedWorkoutStepDurationDurationType.Time => "TIME",
                PlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => PlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => PlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => PlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => PlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => PlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => PlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => PlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => PlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => PlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => PlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => PlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => PlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => PlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}