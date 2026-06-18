
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutSportVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Cycling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant2 value)
        {
            return value switch
            {
                WorkoutSportVariant2.Cycling => "cycling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant2? ToEnum(string value)
        {
            return value switch
            {
                "cycling" => WorkoutSportVariant2.Cycling,
                _ => null,
            };
        }
    }
}