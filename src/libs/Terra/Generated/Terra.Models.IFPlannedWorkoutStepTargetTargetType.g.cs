
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: IF
    /// </summary>
    public enum IFPlannedWorkoutStepTargetTargetType
    {
        /// <summary>
        /// 
        /// </summary>
        Cadence,
        /// <summary>
        /// 
        /// </summary>
        Grade,
        /// <summary>
        /// 
        /// </summary>
        HeartRate,
        /// <summary>
        /// 
        /// </summary>
        HeartRateLap,
        /// <summary>
        /// 
        /// </summary>
        HeartRateMaxPercentage,
        /// <summary>
        /// 
        /// </summary>
        HeartRateThresholdPercentage,
        /// <summary>
        /// 
        /// </summary>
        If,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Pace,
        /// <summary>
        /// 
        /// </summary>
        Power,
        /// <summary>
        /// 
        /// </summary>
        PowerLap,
        /// <summary>
        /// 
        /// </summary>
        PowerPercentage,
        /// <summary>
        /// 
        /// </summary>
        Repetition,
        /// <summary>
        /// 
        /// </summary>
        Resistance,
        /// <summary>
        /// 
        /// </summary>
        Speed,
        /// <summary>
        /// 
        /// </summary>
        SpeedLap,
        /// <summary>
        /// 
        /// </summary>
        SpeedPercentage,
        /// <summary>
        /// 
        /// </summary>
        SwimStroke,
        /// <summary>
        /// 
        /// </summary>
        Tss,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IFPlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IFPlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                IFPlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                IFPlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                IFPlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                IFPlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                IFPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                IFPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                IFPlannedWorkoutStepTargetTargetType.If => "IF",
                IFPlannedWorkoutStepTargetTargetType.Open => "OPEN",
                IFPlannedWorkoutStepTargetTargetType.Pace => "PACE",
                IFPlannedWorkoutStepTargetTargetType.Power => "POWER",
                IFPlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                IFPlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                IFPlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                IFPlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                IFPlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                IFPlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                IFPlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                IFPlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                IFPlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IFPlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => IFPlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => IFPlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => IFPlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => IFPlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => IFPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => IFPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => IFPlannedWorkoutStepTargetTargetType.If,
                "OPEN" => IFPlannedWorkoutStepTargetTargetType.Open,
                "PACE" => IFPlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => IFPlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => IFPlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => IFPlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => IFPlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => IFPlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => IFPlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => IFPlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => IFPlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => IFPlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => IFPlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}