
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepTargetTypeVariant14
    {
        /// <summary>
        ///
        /// </summary>
        Repetition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant14 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant14.Repetition => "repetition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant14? ToEnum(string value)
        {
            return value switch
            {
                "repetition" => WorkoutStepTargetTypeVariant14.Repetition,
                _ => null,
            };
        }
    }
}