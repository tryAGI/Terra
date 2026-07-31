
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        LowerBack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant12 value)
        {
            return value switch
            {
                StrengthMuscleVariant12.LowerBack => "lower_back",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant12? ToEnum(string value)
        {
            return value switch
            {
                "lower_back" => StrengthMuscleVariant12.LowerBack,
                _ => null,
            };
        }
    }
}