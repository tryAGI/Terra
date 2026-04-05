
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: SPEED
    /// </summary>
    public enum SpeedPlannedWorkoutStepTargetTargetType
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
    public static class SpeedPlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeedPlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                SpeedPlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                SpeedPlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                SpeedPlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                SpeedPlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                SpeedPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                SpeedPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                SpeedPlannedWorkoutStepTargetTargetType.If => "IF",
                SpeedPlannedWorkoutStepTargetTargetType.Open => "OPEN",
                SpeedPlannedWorkoutStepTargetTargetType.Pace => "PACE",
                SpeedPlannedWorkoutStepTargetTargetType.Power => "POWER",
                SpeedPlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                SpeedPlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                SpeedPlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                SpeedPlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                SpeedPlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                SpeedPlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                SpeedPlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                SpeedPlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                SpeedPlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeedPlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => SpeedPlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => SpeedPlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => SpeedPlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => SpeedPlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => SpeedPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => SpeedPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => SpeedPlannedWorkoutStepTargetTargetType.If,
                "OPEN" => SpeedPlannedWorkoutStepTargetTargetType.Open,
                "PACE" => SpeedPlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => SpeedPlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => SpeedPlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => SpeedPlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => SpeedPlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => SpeedPlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => SpeedPlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => SpeedPlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => SpeedPlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => SpeedPlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => SpeedPlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}