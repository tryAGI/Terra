
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutSportVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        Walking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant13 value)
        {
            return value switch
            {
                WorkoutSportVariant13.Walking => "walking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant13? ToEnum(string value)
        {
            return value switch
            {
                "walking" => WorkoutSportVariant13.Walking,
                _ => null,
            };
        }
    }
}