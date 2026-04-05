
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum PlannedWorkoutDeleteResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutDeleteResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutDeleteResponseStatus3 value)
        {
            return value switch
            {
                PlannedWorkoutDeleteResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutDeleteResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => PlannedWorkoutDeleteResponseStatus3.Error,
                _ => null,
            };
        }
    }
}