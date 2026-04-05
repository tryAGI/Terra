
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum RepsPlannedWorkoutStepDurationDurationType
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
    public static class RepsPlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepsPlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                RepsPlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                RepsPlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                RepsPlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                RepsPlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                RepsPlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                RepsPlannedWorkoutStepDurationDurationType.Open => "OPEN",
                RepsPlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                RepsPlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                RepsPlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                RepsPlannedWorkoutStepDurationDurationType.Reps => "REPS",
                RepsPlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                RepsPlannedWorkoutStepDurationDurationType.Time => "TIME",
                RepsPlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepsPlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => RepsPlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => RepsPlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => RepsPlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => RepsPlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => RepsPlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => RepsPlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => RepsPlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => RepsPlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => RepsPlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => RepsPlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => RepsPlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => RepsPlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => RepsPlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}