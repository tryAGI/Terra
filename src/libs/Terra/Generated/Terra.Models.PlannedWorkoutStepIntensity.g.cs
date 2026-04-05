
#nullable enable

namespace Terra
{
    /// <summary>
    /// Planned intensity for the workout step
    /// </summary>
    public enum PlannedWorkoutStepIntensity
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Cooldown,
        /// <summary>
        /// 
        /// </summary>
        Interval,
        /// <summary>
        /// 
        /// </summary>
        Recovery,
        /// <summary>
        /// 
        /// </summary>
        Rest,
        /// <summary>
        /// 
        /// </summary>
        Warmup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutStepIntensityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutStepIntensity value)
        {
            return value switch
            {
                PlannedWorkoutStepIntensity.Active => "ACTIVE",
                PlannedWorkoutStepIntensity.Cooldown => "COOLDOWN",
                PlannedWorkoutStepIntensity.Interval => "INTERVAL",
                PlannedWorkoutStepIntensity.Recovery => "RECOVERY",
                PlannedWorkoutStepIntensity.Rest => "REST",
                PlannedWorkoutStepIntensity.Warmup => "WARMUP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutStepIntensity? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PlannedWorkoutStepIntensity.Active,
                "COOLDOWN" => PlannedWorkoutStepIntensity.Cooldown,
                "INTERVAL" => PlannedWorkoutStepIntensity.Interval,
                "RECOVERY" => PlannedWorkoutStepIntensity.Recovery,
                "REST" => PlannedWorkoutStepIntensity.Rest,
                "WARMUP" => PlannedWorkoutStepIntensity.Warmup,
                _ => null,
            };
        }
    }
}