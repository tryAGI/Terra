
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutSportVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Yoga,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant6 value)
        {
            return value switch
            {
                WorkoutSportVariant6.Yoga => "yoga",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant6? ToEnum(string value)
        {
            return value switch
            {
                "yoga" => WorkoutSportVariant6.Yoga,
                _ => null,
            };
        }
    }
}