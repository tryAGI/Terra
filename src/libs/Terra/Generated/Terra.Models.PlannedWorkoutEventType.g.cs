
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum PlannedWorkoutEventType
    {
        /// <summary>
        ///
        /// </summary>
        PlannedWorkout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutEventType value)
        {
            return value switch
            {
                PlannedWorkoutEventType.PlannedWorkout => "planned_workout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutEventType? ToEnum(string value)
        {
            return value switch
            {
                "planned_workout" => PlannedWorkoutEventType.PlannedWorkout,
                _ => null,
            };
        }
    }
}