
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum PlannedWorkoutDeleteResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutDeleteResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutDeleteResponseStatus2 value)
        {
            return value switch
            {
                PlannedWorkoutDeleteResponseStatus2.Error => "error",
                PlannedWorkoutDeleteResponseStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutDeleteResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => PlannedWorkoutDeleteResponseStatus2.Error,
                "success" => PlannedWorkoutDeleteResponseStatus2.Success,
                _ => null,
            };
        }
    }
}