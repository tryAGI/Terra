
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutsPlanWorkoutResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutsPlanWorkoutResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutsPlanWorkoutResponseStatus value)
        {
            return value switch
            {
                WorkoutsPlanWorkoutResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutsPlanWorkoutResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => WorkoutsPlanWorkoutResponseStatus.Success,
                _ => null,
            };
        }
    }
}