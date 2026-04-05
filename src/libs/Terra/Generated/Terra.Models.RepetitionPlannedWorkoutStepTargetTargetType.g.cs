
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of target for the workout - i.e. metric type for which a criterion must be met for the workout to be completed<br/>
    /// Example: REPETITION
    /// </summary>
    public enum RepetitionPlannedWorkoutStepTargetTargetType
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
    public static class RepetitionPlannedWorkoutStepTargetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepetitionPlannedWorkoutStepTargetTargetType value)
        {
            return value switch
            {
                RepetitionPlannedWorkoutStepTargetTargetType.Cadence => "CADENCE",
                RepetitionPlannedWorkoutStepTargetTargetType.Grade => "GRADE",
                RepetitionPlannedWorkoutStepTargetTargetType.HeartRate => "HEART_RATE",
                RepetitionPlannedWorkoutStepTargetTargetType.HeartRateLap => "HEART_RATE_LAP",
                RepetitionPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage => "HEART_RATE_MAX_PERCENTAGE",
                RepetitionPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage => "HEART_RATE_THRESHOLD_PERCENTAGE",
                RepetitionPlannedWorkoutStepTargetTargetType.If => "IF",
                RepetitionPlannedWorkoutStepTargetTargetType.Open => "OPEN",
                RepetitionPlannedWorkoutStepTargetTargetType.Pace => "PACE",
                RepetitionPlannedWorkoutStepTargetTargetType.Power => "POWER",
                RepetitionPlannedWorkoutStepTargetTargetType.PowerLap => "POWER_LAP",
                RepetitionPlannedWorkoutStepTargetTargetType.PowerPercentage => "POWER_PERCENTAGE",
                RepetitionPlannedWorkoutStepTargetTargetType.Repetition => "REPETITION",
                RepetitionPlannedWorkoutStepTargetTargetType.Resistance => "RESISTANCE",
                RepetitionPlannedWorkoutStepTargetTargetType.Speed => "SPEED",
                RepetitionPlannedWorkoutStepTargetTargetType.SpeedLap => "SPEED_LAP",
                RepetitionPlannedWorkoutStepTargetTargetType.SpeedPercentage => "SPEED_PERCENTAGE",
                RepetitionPlannedWorkoutStepTargetTargetType.SwimStroke => "SWIM_STROKE",
                RepetitionPlannedWorkoutStepTargetTargetType.Tss => "TSS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepetitionPlannedWorkoutStepTargetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "CADENCE" => RepetitionPlannedWorkoutStepTargetTargetType.Cadence,
                "GRADE" => RepetitionPlannedWorkoutStepTargetTargetType.Grade,
                "HEART_RATE" => RepetitionPlannedWorkoutStepTargetTargetType.HeartRate,
                "HEART_RATE_LAP" => RepetitionPlannedWorkoutStepTargetTargetType.HeartRateLap,
                "HEART_RATE_MAX_PERCENTAGE" => RepetitionPlannedWorkoutStepTargetTargetType.HeartRateMaxPercentage,
                "HEART_RATE_THRESHOLD_PERCENTAGE" => RepetitionPlannedWorkoutStepTargetTargetType.HeartRateThresholdPercentage,
                "IF" => RepetitionPlannedWorkoutStepTargetTargetType.If,
                "OPEN" => RepetitionPlannedWorkoutStepTargetTargetType.Open,
                "PACE" => RepetitionPlannedWorkoutStepTargetTargetType.Pace,
                "POWER" => RepetitionPlannedWorkoutStepTargetTargetType.Power,
                "POWER_LAP" => RepetitionPlannedWorkoutStepTargetTargetType.PowerLap,
                "POWER_PERCENTAGE" => RepetitionPlannedWorkoutStepTargetTargetType.PowerPercentage,
                "REPETITION" => RepetitionPlannedWorkoutStepTargetTargetType.Repetition,
                "RESISTANCE" => RepetitionPlannedWorkoutStepTargetTargetType.Resistance,
                "SPEED" => RepetitionPlannedWorkoutStepTargetTargetType.Speed,
                "SPEED_LAP" => RepetitionPlannedWorkoutStepTargetTargetType.SpeedLap,
                "SPEED_PERCENTAGE" => RepetitionPlannedWorkoutStepTargetTargetType.SpeedPercentage,
                "SWIM_STROKE" => RepetitionPlannedWorkoutStepTargetTargetType.SwimStroke,
                "TSS" => RepetitionPlannedWorkoutStepTargetTargetType.Tss,
                _ => null,
            };
        }
    }
}