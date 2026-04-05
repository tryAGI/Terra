
#nullable enable

namespace Terra
{
    /// <summary>
    /// Stroke type used for the workout step (e.g. breaststroke)
    /// </summary>
    public enum SwimmingPlannedWorkoutStepStrokeType
    {
        /// <summary>
        /// 
        /// </summary>
        Backstroke,
        /// <summary>
        /// 
        /// </summary>
        Breaststroke,
        /// <summary>
        /// 
        /// </summary>
        Butterfly,
        /// <summary>
        /// 
        /// </summary>
        Freestyle,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Rest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimmingPlannedWorkoutStepStrokeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimmingPlannedWorkoutStepStrokeType value)
        {
            return value switch
            {
                SwimmingPlannedWorkoutStepStrokeType.Backstroke => "BACKSTROKE",
                SwimmingPlannedWorkoutStepStrokeType.Breaststroke => "BREASTSTROKE",
                SwimmingPlannedWorkoutStepStrokeType.Butterfly => "BUTTERFLY",
                SwimmingPlannedWorkoutStepStrokeType.Freestyle => "FREESTYLE",
                SwimmingPlannedWorkoutStepStrokeType.Other => "OTHER",
                SwimmingPlannedWorkoutStepStrokeType.Rest => "REST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimmingPlannedWorkoutStepStrokeType? ToEnum(string value)
        {
            return value switch
            {
                "BACKSTROKE" => SwimmingPlannedWorkoutStepStrokeType.Backstroke,
                "BREASTSTROKE" => SwimmingPlannedWorkoutStepStrokeType.Breaststroke,
                "BUTTERFLY" => SwimmingPlannedWorkoutStepStrokeType.Butterfly,
                "FREESTYLE" => SwimmingPlannedWorkoutStepStrokeType.Freestyle,
                "OTHER" => SwimmingPlannedWorkoutStepStrokeType.Other,
                "REST" => SwimmingPlannedWorkoutStepStrokeType.Rest,
                _ => null,
            };
        }
    }
}