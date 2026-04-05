
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum FixedRestPlannedWorkoutStepDurationDurationType
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
    public static class FixedRestPlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FixedRestPlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                FixedRestPlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                FixedRestPlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                FixedRestPlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                FixedRestPlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                FixedRestPlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                FixedRestPlannedWorkoutStepDurationDurationType.Open => "OPEN",
                FixedRestPlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                FixedRestPlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                FixedRestPlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                FixedRestPlannedWorkoutStepDurationDurationType.Reps => "REPS",
                FixedRestPlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                FixedRestPlannedWorkoutStepDurationDurationType.Time => "TIME",
                FixedRestPlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FixedRestPlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => FixedRestPlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => FixedRestPlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => FixedRestPlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => FixedRestPlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => FixedRestPlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => FixedRestPlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => FixedRestPlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => FixedRestPlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => FixedRestPlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => FixedRestPlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => FixedRestPlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => FixedRestPlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => FixedRestPlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}