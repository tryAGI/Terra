
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutSportVariant7
    {
        /// <summary>
        ///
        /// </summary>
        Pilates,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant7 value)
        {
            return value switch
            {
                WorkoutSportVariant7.Pilates => "pilates",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant7? ToEnum(string value)
        {
            return value switch
            {
                "pilates" => WorkoutSportVariant7.Pilates,
                _ => null,
            };
        }
    }
}