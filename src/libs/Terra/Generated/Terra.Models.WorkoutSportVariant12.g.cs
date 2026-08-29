
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutSportVariant12
    {
        /// <summary>
        ///
        /// </summary>
        Hiking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant12 value)
        {
            return value switch
            {
                WorkoutSportVariant12.Hiking => "hiking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant12? ToEnum(string value)
        {
            return value switch
            {
                "hiking" => WorkoutSportVariant12.Hiking,
                _ => null,
            };
        }
    }
}