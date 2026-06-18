
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepIntensityVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Recovery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepIntensityVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepIntensityVariant4 value)
        {
            return value switch
            {
                WorkoutStepIntensityVariant4.Recovery => "recovery",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepIntensityVariant4? ToEnum(string value)
        {
            return value switch
            {
                "recovery" => WorkoutStepIntensityVariant4.Recovery,
                _ => null,
            };
        }
    }
}