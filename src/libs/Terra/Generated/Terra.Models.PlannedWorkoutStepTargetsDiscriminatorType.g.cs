
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlannedWorkoutStepTargetsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CadencePlannedWorkoutStepTarget,
        /// <summary>
        /// 
        /// </summary>
        HRPlannedWorkoutStepTarget,
        /// <summary>
        /// 
        /// </summary>
        IFPlannedWorkoutStepTarget,
        /// <summary>
        /// 
        /// </summary>
        PacePlannedWorkoutStepTarget,
        /// <summary>
        /// 
        /// </summary>
        PlannedWorkoutStepTarget,
        /// <summary>
        /// 
        /// </summary>
        PowerPlannedWorkoutStepTarget,
        /// <summary>
        /// 
        /// </summary>
        RepetitionPlannedWorkoutStepTarget,
        /// <summary>
        /// 
        /// </summary>
        SpeedPlannedWorkoutStepTarget,
        /// <summary>
        /// 
        /// </summary>
        SwimStrokePlannedWorkoutStepTarget,
        /// <summary>
        /// 
        /// </summary>
        TSSPlannedWorkoutStepTarget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutStepTargetsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutStepTargetsDiscriminatorType value)
        {
            return value switch
            {
                PlannedWorkoutStepTargetsDiscriminatorType.CadencePlannedWorkoutStepTarget => "CadencePlannedWorkoutStepTarget",
                PlannedWorkoutStepTargetsDiscriminatorType.HRPlannedWorkoutStepTarget => "HRPlannedWorkoutStepTarget",
                PlannedWorkoutStepTargetsDiscriminatorType.IFPlannedWorkoutStepTarget => "IFPlannedWorkoutStepTarget",
                PlannedWorkoutStepTargetsDiscriminatorType.PacePlannedWorkoutStepTarget => "PacePlannedWorkoutStepTarget",
                PlannedWorkoutStepTargetsDiscriminatorType.PlannedWorkoutStepTarget => "PlannedWorkoutStepTarget",
                PlannedWorkoutStepTargetsDiscriminatorType.PowerPlannedWorkoutStepTarget => "PowerPlannedWorkoutStepTarget",
                PlannedWorkoutStepTargetsDiscriminatorType.RepetitionPlannedWorkoutStepTarget => "RepetitionPlannedWorkoutStepTarget",
                PlannedWorkoutStepTargetsDiscriminatorType.SpeedPlannedWorkoutStepTarget => "SpeedPlannedWorkoutStepTarget",
                PlannedWorkoutStepTargetsDiscriminatorType.SwimStrokePlannedWorkoutStepTarget => "SwimStrokePlannedWorkoutStepTarget",
                PlannedWorkoutStepTargetsDiscriminatorType.TSSPlannedWorkoutStepTarget => "TSSPlannedWorkoutStepTarget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutStepTargetsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CadencePlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.CadencePlannedWorkoutStepTarget,
                "HRPlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.HRPlannedWorkoutStepTarget,
                "IFPlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.IFPlannedWorkoutStepTarget,
                "PacePlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.PacePlannedWorkoutStepTarget,
                "PlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.PlannedWorkoutStepTarget,
                "PowerPlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.PowerPlannedWorkoutStepTarget,
                "RepetitionPlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.RepetitionPlannedWorkoutStepTarget,
                "SpeedPlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.SpeedPlannedWorkoutStepTarget,
                "SwimStrokePlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.SwimStrokePlannedWorkoutStepTarget,
                "TSSPlannedWorkoutStepTarget" => PlannedWorkoutStepTargetsDiscriminatorType.TSSPlannedWorkoutStepTarget,
                _ => null,
            };
        }
    }
}