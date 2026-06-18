
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutSportVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        Elliptical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutSportVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutSportVariant14 value)
        {
            return value switch
            {
                WorkoutSportVariant14.Elliptical => "elliptical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutSportVariant14? ToEnum(string value)
        {
            return value switch
            {
                "elliptical" => WorkoutSportVariant14.Elliptical,
                _ => null,
            };
        }
    }
}