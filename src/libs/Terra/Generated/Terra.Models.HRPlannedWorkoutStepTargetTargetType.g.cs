
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: HEART_RATE
    /// </summary>
    public enum HRPlannedWorkoutStepTargetTargetType
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
    public static class HRPlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HRPlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                HRPlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                HRPlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                HRPlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                HRPlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                HRPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                HRPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                HRPlannedWorkoutStepTargetTargetType.If => "IF",
                HRPlannedWorkoutStepTargetTargetType.Open => "OPEN",
                HRPlannedWorkoutStepTargetTargetType.Pace => "PACE",
                HRPlannedWorkoutStepTargetTargetType.Power => "POWER",
                HRPlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                HRPlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                HRPlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                HRPlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                HRPlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                HRPlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                HRPlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                HRPlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                HRPlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HRPlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => HRPlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => HRPlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => HRPlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => HRPlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => HRPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => HRPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => HRPlannedWorkoutStepTargetTargetType.If,
                "OPEN" => HRPlannedWorkoutStepTargetTargetType.Open,
                "PACE" => HRPlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => HRPlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => HRPlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => HRPlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => HRPlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => HRPlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => HRPlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => HRPlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => HRPlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => HRPlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => HRPlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}