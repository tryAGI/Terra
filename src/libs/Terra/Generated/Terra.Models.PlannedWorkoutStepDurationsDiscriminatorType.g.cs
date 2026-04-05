
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlannedWorkoutStepDurationsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CaloriesPlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        DistancePlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        FixedRestPlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        HRAbovePlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        HRBelowPlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        PlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        PowerAbovePlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        PowerBelowPlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        RepsPlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        StepsPlannedWorkoutStepDuration,
        /// <summary>
        /// 
        /// </summary>
        TimePlannedWorkoutStepDuration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutStepDurationsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutStepDurationsDiscriminatorType value)
        {
            return value switch
            {
                PlannedWorkoutStepDurationsDiscriminatorType.CaloriesPlannedWorkoutStepDuration => "CaloriesPlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.DistancePlannedWorkoutStepDuration => "DistancePlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.FixedRestPlannedWorkoutStepDuration => "FixedRestPlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.HRAbovePlannedWorkoutStepDuration => "HRAbovePlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.HRBelowPlannedWorkoutStepDuration => "HRBelowPlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.PlannedWorkoutStepDuration => "PlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.PowerAbovePlannedWorkoutStepDuration => "PowerAbovePlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.PowerBelowPlannedWorkoutStepDuration => "PowerBelowPlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.RepsPlannedWorkoutStepDuration => "RepsPlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.StepsPlannedWorkoutStepDuration => "StepsPlannedWorkoutStepDuration",
                PlannedWorkoutStepDurationsDiscriminatorType.TimePlannedWorkoutStepDuration => "TimePlannedWorkoutStepDuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutStepDurationsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CaloriesPlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.CaloriesPlannedWorkoutStepDuration,
                "DistancePlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.DistancePlannedWorkoutStepDuration,
                "FixedRestPlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.FixedRestPlannedWorkoutStepDuration,
                "HRAbovePlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.HRAbovePlannedWorkoutStepDuration,
                "HRBelowPlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.HRBelowPlannedWorkoutStepDuration,
                "PlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.PlannedWorkoutStepDuration,
                "PowerAbovePlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.PowerAbovePlannedWorkoutStepDuration,
                "PowerBelowPlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.PowerBelowPlannedWorkoutStepDuration,
                "RepsPlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.RepsPlannedWorkoutStepDuration,
                "StepsPlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.StepsPlannedWorkoutStepDuration,
                "TimePlannedWorkoutStepDuration" => PlannedWorkoutStepDurationsDiscriminatorType.TimePlannedWorkoutStepDuration,
                _ => null,
            };
        }
    }
}