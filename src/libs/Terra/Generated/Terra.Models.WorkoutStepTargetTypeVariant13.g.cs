
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepTargetTypeVariant13
    {
        /// <summary>
        ///
        /// </summary>
        PowerPercentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant13 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant13.PowerPercentage => "power_percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant13? ToEnum(string value)
        {
            return value switch
            {
                "power_percentage" => WorkoutStepTargetTypeVariant13.PowerPercentage,
                _ => null,
            };
        }
    }
}