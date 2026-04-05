
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum PlannedWorkoutDeleteResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutDeleteResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutDeleteResponseStatus value)
        {
            return value switch
            {
                PlannedWorkoutDeleteResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutDeleteResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PlannedWorkoutDeleteResponseStatus.Error,
                _ => null,
            };
        }
    }
}