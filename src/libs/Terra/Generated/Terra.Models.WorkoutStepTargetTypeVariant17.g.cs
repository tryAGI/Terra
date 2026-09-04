
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepTargetTypeVariant17
    {
        /// <summary>
        ///
        /// </summary>
        Rpe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant17Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant17 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant17.Rpe => "rpe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant17? ToEnum(string value)
        {
            return value switch
            {
                "rpe" => WorkoutStepTargetTypeVariant17.Rpe,
                _ => null,
            };
        }
    }
}