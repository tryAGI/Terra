
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: PACE
    /// </summary>
    public enum PacePlannedWorkoutStepTargetTargetType
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
    public static class PacePlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PacePlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                PacePlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                PacePlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                PacePlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                PacePlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                PacePlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                PacePlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                PacePlannedWorkoutStepTargetTargetType.If => "IF",
                PacePlannedWorkoutStepTargetTargetType.Open => "OPEN",
                PacePlannedWorkoutStepTargetTargetType.Pace => "PACE",
                PacePlannedWorkoutStepTargetTargetType.Power => "POWER",
                PacePlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                PacePlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                PacePlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                PacePlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                PacePlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                PacePlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                PacePlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                PacePlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                PacePlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PacePlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => PacePlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => PacePlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => PacePlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => PacePlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => PacePlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => PacePlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => PacePlannedWorkoutStepTargetTargetType.If,
                "OPEN" => PacePlannedWorkoutStepTargetTargetType.Open,
                "PACE" => PacePlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => PacePlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => PacePlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => PacePlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => PacePlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => PacePlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => PacePlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => PacePlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => PacePlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => PacePlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => PacePlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}