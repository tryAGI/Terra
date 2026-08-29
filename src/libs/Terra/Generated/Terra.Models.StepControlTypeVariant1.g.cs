
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StepControlTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Grade,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepControlTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepControlTypeVariant1 value)
        {
            return value switch
            {
                StepControlTypeVariant1.Grade => "grade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepControlTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "grade" => StepControlTypeVariant1.Grade,
                _ => null,
            };
        }
    }
}