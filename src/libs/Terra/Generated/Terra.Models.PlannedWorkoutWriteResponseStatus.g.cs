
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum PlannedWorkoutWriteResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutWriteResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutWriteResponseStatus value)
        {
            return value switch
            {
                PlannedWorkoutWriteResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutWriteResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PlannedWorkoutWriteResponseStatus.Error,
                _ => null,
            };
        }
    }
}