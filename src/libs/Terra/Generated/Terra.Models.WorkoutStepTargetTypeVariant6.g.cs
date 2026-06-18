
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepTargetTypeVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        SwimStroke,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant6 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant6.SwimStroke => "swim_stroke",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant6? ToEnum(string value)
        {
            return value switch
            {
                "swim_stroke" => WorkoutStepTargetTypeVariant6.SwimStroke,
                _ => null,
            };
        }
    }
}