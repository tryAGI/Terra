
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum PowerAbovePlannedWorkoutStepDurationDurationType
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
    public static class PowerAbovePlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PowerAbovePlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                PowerAbovePlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                PowerAbovePlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                PowerAbovePlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                PowerAbovePlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                PowerAbovePlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                PowerAbovePlannedWorkoutStepDurationDurationType.Open => "OPEN",
                PowerAbovePlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                PowerAbovePlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                PowerAbovePlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                PowerAbovePlannedWorkoutStepDurationDurationType.Reps => "REPS",
                PowerAbovePlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                PowerAbovePlannedWorkoutStepDurationDurationType.Time => "TIME",
                PowerAbovePlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PowerAbovePlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => PowerAbovePlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => PowerAbovePlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => PowerAbovePlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => PowerAbovePlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => PowerAbovePlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => PowerAbovePlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => PowerAbovePlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => PowerAbovePlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => PowerAbovePlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => PowerAbovePlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => PowerAbovePlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => PowerAbovePlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => PowerAbovePlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}