
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlannedWorkoutStepsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CardioPlannedWorkoutStep,
        /// <summary>
        /// 
        /// </summary>
        CyclingPlannedWorkoutStep,
        /// <summary>
        /// 
        /// </summary>
        PilatesPlannedWorkoutStep,
        /// <summary>
        /// 
        /// </summary>
        PlannedWorkoutRepeatStep,
        /// <summary>
        /// 
        /// </summary>
        PlannedWorkoutStep,
        /// <summary>
        /// 
        /// </summary>
        RunningPlannedWorkoutStep,
        /// <summary>
        /// 
        /// </summary>
        StrengthPlannedWorkoutStep,
        /// <summary>
        /// 
        /// </summary>
        SwimmingPlannedWorkoutStep,
        /// <summary>
        /// 
        /// </summary>
        YogaPlannedWorkoutStep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutStepsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutStepsDiscriminatorType value)
        {
            return value switch
            {
                PlannedWorkoutStepsDiscriminatorType.CardioPlannedWorkoutStep => "CardioPlannedWorkoutStep",
                PlannedWorkoutStepsDiscriminatorType.CyclingPlannedWorkoutStep => "CyclingPlannedWorkoutStep",
                PlannedWorkoutStepsDiscriminatorType.PilatesPlannedWorkoutStep => "PilatesPlannedWorkoutStep",
                PlannedWorkoutStepsDiscriminatorType.PlannedWorkoutRepeatStep => "PlannedWorkoutRepeatStep",
                PlannedWorkoutStepsDiscriminatorType.PlannedWorkoutStep => "PlannedWorkoutStep",
                PlannedWorkoutStepsDiscriminatorType.RunningPlannedWorkoutStep => "RunningPlannedWorkoutStep",
                PlannedWorkoutStepsDiscriminatorType.StrengthPlannedWorkoutStep => "StrengthPlannedWorkoutStep",
                PlannedWorkoutStepsDiscriminatorType.SwimmingPlannedWorkoutStep => "SwimmingPlannedWorkoutStep",
                PlannedWorkoutStepsDiscriminatorType.YogaPlannedWorkoutStep => "YogaPlannedWorkoutStep",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutStepsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CardioPlannedWorkoutStep" => PlannedWorkoutStepsDiscriminatorType.CardioPlannedWorkoutStep,
                "CyclingPlannedWorkoutStep" => PlannedWorkoutStepsDiscriminatorType.CyclingPlannedWorkoutStep,
                "PilatesPlannedWorkoutStep" => PlannedWorkoutStepsDiscriminatorType.PilatesPlannedWorkoutStep,
                "PlannedWorkoutRepeatStep" => PlannedWorkoutStepsDiscriminatorType.PlannedWorkoutRepeatStep,
                "PlannedWorkoutStep" => PlannedWorkoutStepsDiscriminatorType.PlannedWorkoutStep,
                "RunningPlannedWorkoutStep" => PlannedWorkoutStepsDiscriminatorType.RunningPlannedWorkoutStep,
                "StrengthPlannedWorkoutStep" => PlannedWorkoutStepsDiscriminatorType.StrengthPlannedWorkoutStep,
                "SwimmingPlannedWorkoutStep" => PlannedWorkoutStepsDiscriminatorType.SwimmingPlannedWorkoutStep,
                "YogaPlannedWorkoutStep" => PlannedWorkoutStepsDiscriminatorType.YogaPlannedWorkoutStep,
                _ => null,
            };
        }
    }
}