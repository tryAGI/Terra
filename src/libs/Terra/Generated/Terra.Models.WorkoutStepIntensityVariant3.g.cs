
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepIntensityVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Cooldown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepIntensityVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepIntensityVariant3 value)
        {
            return value switch
            {
                WorkoutStepIntensityVariant3.Cooldown => "cooldown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepIntensityVariant3? ToEnum(string value)
        {
            return value switch
            {
                "cooldown" => WorkoutStepIntensityVariant3.Cooldown,
                _ => null,
            };
        }
    }
}