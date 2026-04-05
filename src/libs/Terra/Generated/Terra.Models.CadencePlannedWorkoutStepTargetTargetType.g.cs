
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: CADENCE
    /// </summary>
    public enum CadencePlannedWorkoutStepTargetTargetType
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
    public static class CadencePlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CadencePlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                CadencePlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                CadencePlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                CadencePlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                CadencePlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                CadencePlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                CadencePlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                CadencePlannedWorkoutStepTargetTargetType.If => "IF",
                CadencePlannedWorkoutStepTargetTargetType.Open => "OPEN",
                CadencePlannedWorkoutStepTargetTargetType.Pace => "PACE",
                CadencePlannedWorkoutStepTargetTargetType.Power => "POWER",
                CadencePlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                CadencePlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                CadencePlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                CadencePlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                CadencePlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                CadencePlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                CadencePlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                CadencePlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                CadencePlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CadencePlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => CadencePlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => CadencePlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => CadencePlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => CadencePlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => CadencePlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => CadencePlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => CadencePlannedWorkoutStepTargetTargetType.If,
                "OPEN" => CadencePlannedWorkoutStepTargetTargetType.Open,
                "PACE" => CadencePlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => CadencePlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => CadencePlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => CadencePlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => CadencePlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => CadencePlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => CadencePlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => CadencePlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => CadencePlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => CadencePlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => CadencePlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}