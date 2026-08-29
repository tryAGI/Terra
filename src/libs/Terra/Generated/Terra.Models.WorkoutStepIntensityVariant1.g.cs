
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkoutStepIntensityVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Rest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutStepIntensityVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutStepIntensityVariant1 value)
        {
            return value switch
            {
                WorkoutStepIntensityVariant1.Rest => "rest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutStepIntensityVariant1? ToEnum(string value)
        {
            return value switch
            {
                "rest" => WorkoutStepIntensityVariant1.Rest,
                _ => null,
            };
        }
    }
}