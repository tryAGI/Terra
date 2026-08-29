
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMuscleVariant13
    {
        /// <summary>
        ///
        /// </summary>
        LowerBack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant13 value)
        {
            return value switch
            {
                StrengthMuscleVariant13.LowerBack => "lower_back",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant13? ToEnum(string value)
        {
            return value switch
            {
                "lower_back" => StrengthMuscleVariant13.LowerBack,
                _ => null,
            };
        }
    }
}