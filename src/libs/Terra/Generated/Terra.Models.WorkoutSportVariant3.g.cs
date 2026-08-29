
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutSportVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Swimming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant3 value)
        {
            return value switch
            {
                WorkoutSportVariant3.Swimming => "swimming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant3? ToEnum(string value)
        {
            return value switch
            {
                "swimming" => WorkoutSportVariant3.Swimming,
                _ => null,
            };
        }
    }
}