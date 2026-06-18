
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkoutStepIntensityVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepIntensityVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepIntensityVariant5 value)
        {
            return value switch
            {
                WorkoutStepIntensityVariant5.Active => "active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepIntensityVariant5? ToEnum(string value)
        {
            return value switch
            {
                "active" => WorkoutStepIntensityVariant5.Active,
                _ => null,
            };
        }
    }
}