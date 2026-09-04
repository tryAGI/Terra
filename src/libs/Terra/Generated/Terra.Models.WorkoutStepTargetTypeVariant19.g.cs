
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepTargetTypeVariant19
    {
        /// <summary>
        ///
        /// </summary>
        PowerZone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant19Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant19 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant19.PowerZone => "power_zone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant19? ToEnum(string value)
        {
            return value switch
            {
                "power_zone" => WorkoutStepTargetTypeVariant19.PowerZone,
                _ => null,
            };
        }
    }
}