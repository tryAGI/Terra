
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: HEART_RATE
    /// </summary>
    public enum PlannedWorkoutStepTargetTargetType
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
    public static class PlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                PlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                PlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                PlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                PlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                PlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                PlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                PlannedWorkoutStepTargetTargetType.If => "IF",
                PlannedWorkoutStepTargetTargetType.Open => "OPEN",
                PlannedWorkoutStepTargetTargetType.Pace => "PACE",
                PlannedWorkoutStepTargetTargetType.Power => "POWER",
                PlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                PlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                PlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                PlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                PlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                PlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                PlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                PlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                PlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => PlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => PlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => PlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => PlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => PlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => PlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => PlannedWorkoutStepTargetTargetType.If,
                "OPEN" => PlannedWorkoutStepTargetTargetType.Open,
                "PACE" => PlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => PlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => PlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => PlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => PlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => PlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => PlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => PlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => PlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => PlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => PlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}