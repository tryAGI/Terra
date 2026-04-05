
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: TSS
    /// </summary>
    public enum TSSPlannedWorkoutStepTargetTargetType
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
    public static class TSSPlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TSSPlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                TSSPlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                TSSPlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                TSSPlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                TSSPlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                TSSPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                TSSPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                TSSPlannedWorkoutStepTargetTargetType.If => "IF",
                TSSPlannedWorkoutStepTargetTargetType.Open => "OPEN",
                TSSPlannedWorkoutStepTargetTargetType.Pace => "PACE",
                TSSPlannedWorkoutStepTargetTargetType.Power => "POWER",
                TSSPlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                TSSPlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                TSSPlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                TSSPlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                TSSPlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                TSSPlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                TSSPlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                TSSPlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                TSSPlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TSSPlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => TSSPlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => TSSPlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => TSSPlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => TSSPlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => TSSPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => TSSPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => TSSPlannedWorkoutStepTargetTargetType.If,
                "OPEN" => TSSPlannedWorkoutStepTargetTargetType.Open,
                "PACE" => TSSPlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => TSSPlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => TSSPlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => TSSPlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => TSSPlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => TSSPlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => TSSPlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => TSSPlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => TSSPlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => TSSPlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => TSSPlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}