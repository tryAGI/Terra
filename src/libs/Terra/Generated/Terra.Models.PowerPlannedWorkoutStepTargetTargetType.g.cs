
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: POWER
    /// </summary>
    public enum PowerPlannedWorkoutStepTargetTargetType
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
    public static class PowerPlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PowerPlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                PowerPlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                PowerPlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                PowerPlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                PowerPlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                PowerPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                PowerPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                PowerPlannedWorkoutStepTargetTargetType.If => "IF",
                PowerPlannedWorkoutStepTargetTargetType.Open => "OPEN",
                PowerPlannedWorkoutStepTargetTargetType.Pace => "PACE",
                PowerPlannedWorkoutStepTargetTargetType.Power => "POWER",
                PowerPlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                PowerPlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                PowerPlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                PowerPlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                PowerPlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                PowerPlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                PowerPlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                PowerPlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                PowerPlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PowerPlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => PowerPlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => PowerPlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => PowerPlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => PowerPlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => PowerPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => PowerPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => PowerPlannedWorkoutStepTargetTargetType.If,
                "OPEN" => PowerPlannedWorkoutStepTargetTargetType.Open,
                "PACE" => PowerPlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => PowerPlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => PowerPlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => PowerPlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => PowerPlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => PowerPlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => PowerPlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => PowerPlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => PowerPlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => PowerPlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => PowerPlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}