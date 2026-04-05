
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: SWIM_STROKE
    /// </summary>
    public enum SwimStrokePlannedWorkoutStepTargetTargetType
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
    public static class SwimStrokePlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimStrokePlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                SwimStrokePlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                SwimStrokePlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                SwimStrokePlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                SwimStrokePlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                SwimStrokePlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                SwimStrokePlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                SwimStrokePlannedWorkoutStepTargetTargetType.If => "IF",
                SwimStrokePlannedWorkoutStepTargetTargetType.Open => "OPEN",
                SwimStrokePlannedWorkoutStepTargetTargetType.Pace => "PACE",
                SwimStrokePlannedWorkoutStepTargetTargetType.Power => "POWER",
                SwimStrokePlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                SwimStrokePlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                SwimStrokePlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                SwimStrokePlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                SwimStrokePlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                SwimStrokePlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                SwimStrokePlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                SwimStrokePlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                SwimStrokePlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimStrokePlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => SwimStrokePlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => SwimStrokePlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => SwimStrokePlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => SwimStrokePlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => SwimStrokePlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => SwimStrokePlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => SwimStrokePlannedWorkoutStepTargetTargetType.If,
                "OPEN" => SwimStrokePlannedWorkoutStepTargetTargetType.Open,
                "PACE" => SwimStrokePlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => SwimStrokePlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => SwimStrokePlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => SwimStrokePlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => SwimStrokePlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => SwimStrokePlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => SwimStrokePlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => SwimStrokePlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => SwimStrokePlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => SwimStrokePlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => SwimStrokePlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}