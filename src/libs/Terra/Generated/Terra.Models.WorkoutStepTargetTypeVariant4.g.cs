
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepTargetTypeVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Cadence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepTargetTypeVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepTargetTypeVariant4 value)
        {
            return value switch
            {
                WorkoutStepTargetTypeVariant4.Cadence => "cadence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepTargetTypeVariant4? ToEnum(string value)
        {
            return value switch
            {
                "cadence" => WorkoutStepTargetTypeVariant4.Cadence,
                _ => null,
            };
        }
    }
}