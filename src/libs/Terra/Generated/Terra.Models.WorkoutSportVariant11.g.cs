
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutSportVariant11
    {
        /// <summary>
        ///
        /// </summary>
        BackcountrySkiing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant11 value)
        {
            return value switch
            {
                WorkoutSportVariant11.BackcountrySkiing => "backcountry_skiing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant11? ToEnum(string value)
        {
            return value switch
            {
                "backcountry_skiing" => WorkoutSportVariant11.BackcountrySkiing,
                _ => null,
            };
        }
    }
}