
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum PlannedWorkoutFetchResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutFetchResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutFetchResponseStatus value)
        {
            return value switch
            {
                PlannedWorkoutFetchResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutFetchResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => PlannedWorkoutFetchResponseStatus.Error,
                _ => null,
            };
        }
    }
}