
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        LowerBack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant11 value)
        {
            return value switch
            {
                StrengthMuscleVariant11.LowerBack => "lower_back",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant11? ToEnum(string value)
        {
            return value switch
            {
                "lower_back" => StrengthMuscleVariant11.LowerBack,
                _ => null,
            };
        }
    }
}