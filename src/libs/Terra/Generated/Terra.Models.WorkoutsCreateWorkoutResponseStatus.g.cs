
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutsCreateWorkoutResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutsCreateWorkoutResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutsCreateWorkoutResponseStatus value)
        {
            return value switch
            {
                WorkoutsCreateWorkoutResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutsCreateWorkoutResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => WorkoutsCreateWorkoutResponseStatus.Success,
                _ => null,
            };
        }
    }
}