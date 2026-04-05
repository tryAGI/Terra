
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum TimePlannedWorkoutStepDurationDurationType
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
    public static class TimePlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimePlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                TimePlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                TimePlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                TimePlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                TimePlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                TimePlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                TimePlannedWorkoutStepDurationDurationType.Open => "OPEN",
                TimePlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                TimePlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                TimePlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                TimePlannedWorkoutStepDurationDurationType.Reps => "REPS",
                TimePlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                TimePlannedWorkoutStepDurationDurationType.Time => "TIME",
                TimePlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimePlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => TimePlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => TimePlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => TimePlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => TimePlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => TimePlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => TimePlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => TimePlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => TimePlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => TimePlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => TimePlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => TimePlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => TimePlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => TimePlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}