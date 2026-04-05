
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum HRAbovePlannedWorkoutStepDurationDurationType
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
    public static class HRAbovePlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HRAbovePlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                HRAbovePlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                HRAbovePlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                HRAbovePlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                HRAbovePlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                HRAbovePlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                HRAbovePlannedWorkoutStepDurationDurationType.Open => "OPEN",
                HRAbovePlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                HRAbovePlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                HRAbovePlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                HRAbovePlannedWorkoutStepDurationDurationType.Reps => "REPS",
                HRAbovePlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                HRAbovePlannedWorkoutStepDurationDurationType.Time => "TIME",
                HRAbovePlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HRAbovePlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => HRAbovePlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => HRAbovePlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => HRAbovePlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => HRAbovePlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => HRAbovePlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => HRAbovePlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => HRAbovePlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => HRAbovePlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => HRAbovePlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => HRAbovePlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => HRAbovePlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => HRAbovePlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => HRAbovePlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}