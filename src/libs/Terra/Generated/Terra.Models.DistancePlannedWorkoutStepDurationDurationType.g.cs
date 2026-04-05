
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of condition that must be fulfilled to consider the workout step complete
    /// </summary>
    public enum DistancePlannedWorkoutStepDurationDurationType
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
    public static class DistancePlannedWorkoutStepDurationDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DistancePlannedWorkoutStepDurationDurationType value)
        {
            return value switch
            {
                DistancePlannedWorkoutStepDurationDurationType.Calories => "CALORIES",
                DistancePlannedWorkoutStepDurationDurationType.DistanceMeters => "DISTANCE_METERS",
                DistancePlannedWorkoutStepDurationDurationType.FixedRest => "FIXED_REST",
                DistancePlannedWorkoutStepDurationDurationType.HrGreaterThan => "HR_GREATER_THAN",
                DistancePlannedWorkoutStepDurationDurationType.HrLessThan => "HR_LESS_THAN",
                DistancePlannedWorkoutStepDurationDurationType.Open => "OPEN",
                DistancePlannedWorkoutStepDurationDurationType.PowerGreaterThan => "POWER_GREATER_THAN",
                DistancePlannedWorkoutStepDurationDurationType.PowerLessThan => "POWER_LESS_THAN",
                DistancePlannedWorkoutStepDurationDurationType.RepetitionTime => "REPETITION_TIME",
                DistancePlannedWorkoutStepDurationDurationType.Reps => "REPS",
                DistancePlannedWorkoutStepDurationDurationType.Steps => "STEPS",
                DistancePlannedWorkoutStepDurationDurationType.Time => "TIME",
                DistancePlannedWorkoutStepDurationDurationType.TimeAtValidCda => "TIME_AT_VALID_CDA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DistancePlannedWorkoutStepDurationDurationType? ToEnum(string value)
        {
            return value switch
            {
                "CALORIES" => DistancePlannedWorkoutStepDurationDurationType.Calories,
                "DISTANCE_METERS" => DistancePlannedWorkoutStepDurationDurationType.DistanceMeters,
                "FIXED_REST" => DistancePlannedWorkoutStepDurationDurationType.FixedRest,
                "HR_GREATER_THAN" => DistancePlannedWorkoutStepDurationDurationType.HrGreaterThan,
                "HR_LESS_THAN" => DistancePlannedWorkoutStepDurationDurationType.HrLessThan,
                "OPEN" => DistancePlannedWorkoutStepDurationDurationType.Open,
                "POWER_GREATER_THAN" => DistancePlannedWorkoutStepDurationDurationType.PowerGreaterThan,
                "POWER_LESS_THAN" => DistancePlannedWorkoutStepDurationDurationType.PowerLessThan,
                "REPETITION_TIME" => DistancePlannedWorkoutStepDurationDurationType.RepetitionTime,
                "REPS" => DistancePlannedWorkoutStepDurationDurationType.Reps,
                "STEPS" => DistancePlannedWorkoutStepDurationDurationType.Steps,
                "TIME" => DistancePlannedWorkoutStepDurationDurationType.Time,
                "TIME_AT_VALID_CDA" => DistancePlannedWorkoutStepDurationDurationType.TimeAtValidCda,
                _ => null,
            };
        }
    }
}