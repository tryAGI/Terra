
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepTargetTypeVariant16
    {
        /// <summary>
        ///
        /// </summary>
        If,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant16 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant16.If => "if",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant16? ToEnum(string value)
        {
            return value switch
            {
                "if" => WorkoutStepTargetTypeVariant16.If,
                _ => null,
            };
        }
    }
}