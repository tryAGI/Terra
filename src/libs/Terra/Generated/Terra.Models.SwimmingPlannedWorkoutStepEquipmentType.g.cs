
#nullable enable

namespace Terra
{
    /// <summary>
    /// Workout equipment to be used during the workout step
    /// </summary>
    public enum SwimmingPlannedWorkoutStepEquipmentType
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        SwimFins,
        /// <summary>
        /// 
        /// </summary>
        SwimKickboard,
        /// <summary>
        /// 
        /// </summary>
        SwimPaddles,
        /// <summary>
        /// 
        /// </summary>
        SwimPullBuoy,
        /// <summary>
        /// 
        /// </summary>
        SwimSnorkel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimmingPlannedWorkoutStepEquipmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimmingPlannedWorkoutStepEquipmentType value)
        {
            return value switch
            {
                SwimmingPlannedWorkoutStepEquipmentType.None => "NONE",
                SwimmingPlannedWorkoutStepEquipmentType.SwimFins => "SWIM_FINS",
                SwimmingPlannedWorkoutStepEquipmentType.SwimKickboard => "SWIM_KICKBOARD",
                SwimmingPlannedWorkoutStepEquipmentType.SwimPaddles => "SWIM_PADDLES",
                SwimmingPlannedWorkoutStepEquipmentType.SwimPullBuoy => "SWIM_PULL_BUOY",
                SwimmingPlannedWorkoutStepEquipmentType.SwimSnorkel => "SWIM_SNORKEL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimmingPlannedWorkoutStepEquipmentType? ToEnum(string value)
        {
            return value switch
            {
                "NONE" => SwimmingPlannedWorkoutStepEquipmentType.None,
                "SWIM_FINS" => SwimmingPlannedWorkoutStepEquipmentType.SwimFins,
                "SWIM_KICKBOARD" => SwimmingPlannedWorkoutStepEquipmentType.SwimKickboard,
                "SWIM_PADDLES" => SwimmingPlannedWorkoutStepEquipmentType.SwimPaddles,
                "SWIM_PULL_BUOY" => SwimmingPlannedWorkoutStepEquipmentType.SwimPullBuoy,
                "SWIM_SNORKEL" => SwimmingPlannedWorkoutStepEquipmentType.SwimSnorkel,
                _ => null,
            };
        }
    }
}