
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum PowerBelowPlannedWorkoutStepDurationDurationType
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
    public static class PowerBelowPlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PowerBelowPlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                PowerBelowPlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                PowerBelowPlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                PowerBelowPlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                PowerBelowPlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                PowerBelowPlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                PowerBelowPlannedWorkoutStepDurationDurationType.Open => "OPEN",
                PowerBelowPlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                PowerBelowPlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                PowerBelowPlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                PowerBelowPlannedWorkoutStepDurationDurationType.Reps => "REPS",
                PowerBelowPlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                PowerBelowPlannedWorkoutStepDurationDurationType.Time => "TIME",
                PowerBelowPlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PowerBelowPlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => PowerBelowPlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => PowerBelowPlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => PowerBelowPlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => PowerBelowPlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => PowerBelowPlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => PowerBelowPlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => PowerBelowPlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => PowerBelowPlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => PowerBelowPlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => PowerBelowPlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => PowerBelowPlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => PowerBelowPlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => PowerBelowPlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}