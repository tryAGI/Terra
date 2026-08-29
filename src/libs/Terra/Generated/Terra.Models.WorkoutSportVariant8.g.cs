
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutSportVariant8
    {
        /// <summary>
        ///
        /// </summary>
        Cardio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant8 value)
        {
            return value switch
            {
                WorkoutSportVariant8.Cardio => "cardio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant8? ToEnum(string value)
        {
            return value switch
            {
                "cardio" => WorkoutSportVariant8.Cardio,
                _ => null,
            };
        }
    }
}