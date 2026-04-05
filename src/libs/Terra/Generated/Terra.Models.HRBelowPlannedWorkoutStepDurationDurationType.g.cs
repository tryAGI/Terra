
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum HRBelowPlannedWorkoutStepDurationDurationType
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
    public static class HRBelowPlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HRBelowPlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                HRBelowPlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                HRBelowPlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                HRBelowPlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                HRBelowPlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                HRBelowPlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                HRBelowPlannedWorkoutStepDurationDurationType.Open => "OPEN",
                HRBelowPlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                HRBelowPlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                HRBelowPlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                HRBelowPlannedWorkoutStepDurationDurationType.Reps => "REPS",
                HRBelowPlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                HRBelowPlannedWorkoutStepDurationDurationType.Time => "TIME",
                HRBelowPlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HRBelowPlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => HRBelowPlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => HRBelowPlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => HRBelowPlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => HRBelowPlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => HRBelowPlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => HRBelowPlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => HRBelowPlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => HRBelowPlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => HRBelowPlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => HRBelowPlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => HRBelowPlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => HRBelowPlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => HRBelowPlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}